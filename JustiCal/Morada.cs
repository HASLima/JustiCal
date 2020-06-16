﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace JustiCal
{
    namespace Model
    {
        /// <summary>
        /// Classe para a criação de uma morada com os campos previstos pelos CTT no seu manual de endereçamento de Abril de 2018
        /// </summary>
        public class Morada
        {
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
            /// <param name="arteria">Artéria (ex: Rua, Praça, Travessa)</param>
            /// <param name="nomearteria">Nome da Artéria incluindo a preposição(ex: da Liberdade, Doutor Fernando Amado, António Alves)</param>
            /// <param name="identificacaoPorta">Número de policia, ou número de lote ou número de cci (ex: 44, lote 12, CCI 512)</param>
            /// <param name="identificacaoAlojamento">Identificação do alojamento (ex: 1.º dto, 2.º esq., R/C frente)</param>
            /// <param name="codigoPostalCP4">Primeiros 4 algarismos do código postal(ex: 4700)</param>
            /// <param name="codigoPostalCP3">Últimos 3 algarismos do código postal (ex: 512)</param>
            /// <param name="pais">País, por defeito é passado "Portugal"</param>
            /// <param name="localidade">Localidade. Só deve ser usado se o país não for Portugal (ex: Genk)</param>
            /// <param name="designacaoPostal">Designação Postal. Só deve ser usado se o país não for Portugal (ex: MAASEIK)</param>
            public Morada(string arteria, string nomearteria, string identificacaoPorta, string identificacaoAlojamento, string codigoPostalCP4, string codigoPostalCP3, string pais = "Portugal", string localidade = null, string designacaoPostal = null)
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
                    var assembly = Assembly.GetExecutingAssembly();
                    var resourceName = "JustiCal.Properties.todos_cp.txt";
                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        while (!reader.EndOfStream && Localidade == null)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            if (values[14] == CodigoPostalCP4 && values[15] == CodigoPostalCP3)
                            {
                                Localidade = values[3];
                                DesignacaoPostal = values[16];
                            }
                        }
                    }
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
                str += String.Format("\n{0}-{1} {2}", CodigoPostalCP4, CodigoPostalCP3, DesignacaoPostal);
                if (Pais != null && Pais != "Portugal")
                    str += String.Format("\n{0}", Pais);
                return str;
            }
        } 
    }
}