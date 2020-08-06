using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Diagnostics;

namespace JustiCal
{
    namespace Model
    {
        /// <summary>
        /// Classe para a criação de uma morada com os campos previstos pelos CTT no seu manual de endereçamento de Abril de 2018
        /// </summary>
        public class Morada
        {
            public string Descricao { get; set; } //serve para descrever a morada. Ex: Principal, Pais, Pais de Origem...
            public string Arteria { get; set; }
            public string NomeArteria { get; set; }
            public string IdentificacaoPorta { get; set; }
            public string IdentificacaoAlojamento { get; set; }
            public string Localidade { get; set; }
            public string CodigoPostalCP4 { get; set; }
            public string CodigoPostalCP3 { get; set; }
            public string DesignacaoPostal { get; private set; }
            public string Pais { get; set; }

            public Morada()
            {

            }
            /// <summary>
            /// Constructor for Morada
            /// </summary>
            /// <param name="descricao">Descrição da morada a ser criada (ex: Principal, Pais, Pais de Origem...)</param>
            /// <param name="arteria">Artéria (ex: Rua, Praça, Travessa)</param>
            /// <param name="nomearteria">Nome da Artéria incluindo a preposição(ex: da Liberdade, Doutor Fernando Amado, António Alves)</param>
            /// <param name="identificacaoPorta">Número de policia, ou número de lote ou número de cci (ex: 44, lote 12, CCI 512)</param>
            /// <param name="identificacaoAlojamento">Identificação do alojamento (ex: 1.º dto, 2.º esq., R/C frente)</param>
            /// <param name="codigoPostalCP4">Primeiros 4 algarismos do código postal(ex: 4700)</param>
            /// <param name="codigoPostalCP3">Últimos 3 algarismos do código postal (ex: 512)</param>
            /// <param name="pais">País, por defeito é passado "Portugal"</param>
            /// <param name="localidade">Localidade. Só deve ser usado se o país não for Portugal (ex: Genk)</param>
            /// <param name="designacaoPostal">Designação Postal. Só deve ser usado se o país não for Portugal (ex: MAASEIK)</param>
            public Morada(string descricao, string arteria, string nomearteria, string identificacaoPorta, string identificacaoAlojamento, string codigoPostalCP4, string codigoPostalCP3, string pais = "Portugal", string localidade = null, string designacaoPostal = null)
            {
                Arteria = arteria;
                NomeArteria = nomearteria;
                IdentificacaoPorta = identificacaoPorta;
                IdentificacaoAlojamento = identificacaoAlojamento;
                CodigoPostalCP4 = codigoPostalCP4;
                CodigoPostalCP3 = codigoPostalCP3;
                Pais = pais;


                if (Pais == "Portugal")
                {
                    //use the embedded resource file todos_cp.txt
                    Localidade = GetLocalidadeFromCodigoPostal(CodigoPostalCP4, CodigoPostalCP3);
                    DesignacaoPostal = GetDesignacaoPostalFromCodigoPostal(CodigoPostalCP4, CodigoPostalCP3);
                }
                else
                {
                    Localidade = localidade;
                    DesignacaoPostal = designacaoPostal;
                }
            }

            public override string ToString()
            {
                string str = String.Format("{0} {1}", Arteria, NomeArteria);
                if (IdentificacaoPorta != null)
                    str += String.Format(", {0}", IdentificacaoPorta);
                if (IdentificacaoAlojamento != null)
                    str += String.Format(", {0}", IdentificacaoAlojamento);
                if (Localidade != null && !String.Equals(Localidade, DesignacaoPostal, StringComparison.OrdinalIgnoreCase))
                    str += String.Format("\n{0}", Localidade);
                if (Pais != null && Pais != "Portugal")
                {
                    str += String.Format("\n{0} {1}", CodigoPostalCP4, DesignacaoPostal);
                    str += String.Format("\n{0}", Pais);
                }
                else
                    str += String.Format("\n{0}-{1} {2}", CodigoPostalCP4, CodigoPostalCP3, DesignacaoPostal);
                return str;
            }

            public static string GetLocalidadeFromCodigoPostal(string cp4, string cp3)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "JustiCal.Properties.todos_cp.txt";
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (var reader = new System.IO.StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (values[14] == cp4 && values[15] == cp3)
                        {
                            return values[3];
                        }
                    }
                }
                return null;
            }

            public static string GetDesignacaoPostalFromCodigoPostal(string cp4, string cp3)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "JustiCal.Properties.todos_cp.txt";
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (var reader = new System.IO.StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (values[14] == cp4 && values[15] == cp3)
                        {
                            return values[16];
                        }
                    }
                }
                return null;
            }

            public static bool CP4IsValid(string cp4)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "JustiCal.Properties.todos_cp.txt";
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (var reader = new System.IO.StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (values[14] == cp4)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            public static bool CPIsValid(string cp4, string cp3)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "JustiCal.Properties.todos_cp.txt";
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (var reader = new System.IO.StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (values[14] == cp4 && values[15] == cp3)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            public static List<string> CountryList()
            {
                List<string> CultureList = new List<string>();

                CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

                foreach (CultureInfo item in getCultureInfo)
                {
                    RegionInfo GetRegionInfo = new RegionInfo(item.LCID);

                    if (!(CultureList.Contains(GetRegionInfo.DisplayName)))
                    {
                        CultureList.Add(GetRegionInfo.DisplayName);
                    }
                }

                CultureList.Sort();

                return CultureList;
            }

            public static List<string[]> ProcurarCP(string cp4, string cp3)
            {
                List<string[]> lista = new List<string[]>();

                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "JustiCal.Properties.todos_cp.txt";
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (var reader = new System.IO.StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (values[14] == cp4 && values[15] == cp3)
                        {
                            string[] morada = new string[4];
                            morada[0] = values[5];

                            morada[1] = values[6];
                            for (int i = 7; i < 10; i++)
                            {
                                if (values[i].Length > 0)
                                {
                                    morada[1] += " " + values[i];
                                }
                            }
                            Debug.WriteLine(morada[1]);

                            morada[2] = values[3];

                            morada[3] = values[16];

                            lista.Add(morada);
                        }
                    }
                }
                return lista;
            }
        } 
    }
}
