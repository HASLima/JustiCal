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
            public string Detentor { get; set; } //Serve para descrever quem poderá atender o contacto telefónico a ser criado. Principalmente para contactos de emergência. Ex: Sr. Carlos Santos (pai)

            public string Descricao { get; set; } //Serve para descrever o contacto telefónico a ser criado. Por exemplo: Principal, Fixo, Emergência, Pais
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

            /// <summary>
            /// Constructor de um contacto telefónico
            /// </summary>
            /// <param name="numero">Número de telefone. Uma string com o número de telefone, sem indicativo internacional</param>
            /// <param name="descricao">Descrição do contacto. Uma string para descrever o contacto a ser criado. Ex: "Principal", "Fixo", "Emergência", "Pais de origem"...</param>
            /// <param name="detentor">Detentor do contacto. Uma string para descrever quem poderá atender este contacto. Particularmente útil para contacto de emergência Ex: "Sr. Carlos (pai)"</param>
            /// <param name="indicativo">Indicativo internacional. Uma string para o indicativo internacional, caso o número não seja Português. Ex: "+34"</param>
            public ContactoTelefonico(string numero, string descricao, string detentor = null, string indicativo = "351")
            {
                Numero = numero;
                Indicativo = indicativo;
                Descricao = descricao;
                Detentor = detentor;
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