using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace JustiCal
{
	namespace Model
	{
		public class ContactoTelefonico
		{
            public string Numero { get; set; }
            public string Indicativo { get; set; }
            public string Pais { get { return CountryFromCode(Indicativo).Result; } }


            public ContactoTelefonico(string numero, string indicativo = "351")
            {
                Numero = numero;
                Indicativo = indicativo;
            }

            public async Task<string> CountryFromCode(string code)
            {
                string name = "";    //The name of the country provided by the api
                string pt = "";      //The portuguese translation of the country provided by the api
                HttpResponseMessage response = await ModelClass.client.GetAsync(String.Format("https://restcountries.eu/rest/v2/callingcode/{0}?fields=name;translations", code));
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                JArray array = JsonConvert.DeserializeObject<JArray>(responseBody);

                foreach (JObject country in array)
                {
                    foreach (var pair in country)
                    {
                        if (pair.Key == "name")
                            name = pair.Value.ToString();
                        if (pair.Key == "translations")
                        {
                            JObject parsed = JObject.Parse(pair.Value.ToString());
                            foreach (var item in parsed)
                            {
                                if (item.Key == "pt")
                                {
                                    pt = item.Value.ToString();
                                }
                            }
                        }
                    }
                }
                if (pt != "?????")
                    return pt;
                else
                    return name;
            }
        }
	}
}