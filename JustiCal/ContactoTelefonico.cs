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
using System.Windows.Forms;

namespace JustiCal
{
	namespace Model
	{
		public class ContactoTelefonico
		{
            public string Numero { get; set; }
            public string Indicativo { get; set; }
            public string Pais
            {
                get
                {
                    try
                    {
                        return CountryFromCode(Indicativo).Result;
                    }
                    catch (AggregateException ex)
                    {
                        if (ex.InnerException != null)
                        {
                            MessageBox.Show(ex.InnerException.Message);
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);

                        }
                        return null;
                    }
                    catch (CountryNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                        throw;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                    }


                }
            }


            public ContactoTelefonico(string numero, string indicativo = "351")
            {
                Numero = numero;
                Indicativo = indicativo;
            }
            /// <summary>
            /// Returns the country name given a international dialer code
            /// </summary>
            /// <param name="code">The international dialer code.</param>
            /// <returns>A string with the country name if successful</returns>
            public async Task<string> CountryFromCode(string code)
            {
                string name = "";    //The name of the country provided by the api
                string pt = "";      //The portuguese translation of the country provided by the api
                HttpResponseMessage response = await ModelClass.client.GetAsync(String.Format("https://restcountries.eu/rest/v2/callingcode/{0}?fields=name;translations", code));
                if (response.StatusCode == (HttpStatusCode) 404)
                    throw new CountryNotFoundException(code);
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

        class CountryNotFoundException : Exception
        {
            public CountryNotFoundException()
            {

            }

            public CountryNotFoundException(string code)
                : base (String.Format("Não foi possível concluir. Não foi encontrado nenhum país cujo indicativo internacional seja {0}.\nTerá inserido o indicativo correctamente?", code))
            {
            }
        }
	}
}