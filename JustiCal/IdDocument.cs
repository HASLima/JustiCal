using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;

namespace JustiCal
{
    namespace Model
    {
        public class IdDocument
        {
            public enum DocumentType
            {
                BilheteDeIdentidadeMilitar = 0,
                CartaoDeCidadao = 1,
                BilheteDeIdentidade = 2,
                TituloDeResidencia = 3,
                Passaporte = 4

            }


            public readonly Dictionary<int, string> DocumentTypes = new Dictionary<int, string>()
            {
                {0, "Bilhete de Identidade Militar"},
                {1, "Cartão de Cidadão"},
                {2, "Bilhete de Identidade"},
                {3, "Título de Residência"},
                {4, "Passaporte"}
            };

            public readonly Dictionary<int, string> AbreviatedDocumentTypes = new Dictionary<int, string>()
            {
                {0, "BIM" },
                {1, "CC" },
                {2, "BI" },
                {3, "TR" },
                {4, "P" }
            };

            public enum Organismo
            {
                Armada = 0,
                Exercito = 1,
                ForcaAerea = 2,
                GNR = 3
            }

            public readonly Dictionary<int, string> Organismos = new Dictionary<int, string>()
            {
                {0, "Armada" },
                {1, "Exército Português" },
                {2, "Força Aérea" },
                {3, "Guarda Nacional Republicana" }
            };

            public string DocumentNumber { get; set; }
            public DateTime? ExpiryDate { get; set; }
            public DateTime? IssueDate { get; set; }
            public DocumentType IdDocumentType { get; set; }

            public IdDocument()
            {

            }

            public override string ToString()
            {
                return String.Format("{0} {1}", AbreviatedDocumentTypes[(int)IdDocumentType], DocumentNumber);
            }

        }
        /// <summary>
        /// Esta class define um cartão de cidadão. Inclui as propriedades relativas ao número de identificação civil, número de controlo do número de identificação civil, versão do documento e número de controlo do número do documento. Inclui ainda o número completo do documento. Herda da class IdDocument as propriedades data de validade e de emissão.
        /// </summary>
        class CartaoDeCidadao : IdDocument
        {
            /// <summary>
            /// Construtor de Cartão de Cidadão
            /// </summary>
            /// <param name="numero">Número de cartão de cidadão, com 12 caracteres</param>
            /// <param name="dataDeValidade">Data de validade</param>
            public CartaoDeCidadao(string numero, DateTime dataDeValidade)
            {
                if (numero.Length != 12)
                    throw new ArgumentException("O número de cartão de cidadão não tem o número de caracteres correcto. Devem constar 12 caracteres");

                CivilianIdNumber = numero.Substring(0, 8);

                try
                {
                    CivilianIdNumberCheckDigit = Int16.Parse(numero.Substring(8, 1));
                }
                catch (FormatException)
                { 
                    throw;
                }
                Version = numero.Substring(9, 2);
                DocumentNumberCheckDigit = numero.Substring(11, 1);
                ExpiryDate = dataDeValidade;
                IssueDate = null;
                IdDocumentType = DocumentType.CartaoDeCidadao;
            }
            /// <summary>
            /// Construtor de Cartão de Cidadão
            /// </summary>
            /// <param name="numero">Número de cartão de cidadão, com 12 caracteres</param>
            /// <param name="dia">O dia da data de validade</param>
            /// <param name="mes">O mes da data de validade</param>
            /// <param name="ano">O ano da data de validade</param>
            public CartaoDeCidadao(string numero, int dia, int mes, int ano)
                : this (numero, new DateTime(ano, mes, dia))
            {
            }

            //De acordo com o Documento "Validação do Número de Documento Cartão de Cidadão v1.0.doc (https://www.autenticacao.gov.pt/documents/20126/115760/Valida%C3%A7%C3%A3o+de+N%C3%BAmero+de+Documento+do+Cart%C3%A3o+de+Cidad%C3%A3o.pdf/bdc4eb37-7316-3ff4-164a-f869382b7053?t=1588780568207&download=true)
            //O número de cartão de cidadão é composto da segunte forma:
            //DDDDDDDD C AAT
            //onde:
            //D - Número de Identificação Civil(nunca muda) [0...9]
            //C - CheckDigit do Número de Identificação Civil (nunca muda) [0...9]
            //A - Versão (muda a cada cartão emitido) [A...Z, 0...9]
            //T - CheckDigit do Número de Documento (muda a cada cartão emitido) [0...9]

            public string CivilianIdNumber { get; set; }
            public int CivilianIdNumberCheckDigit { get; set; }
            public string Version { get; set; }
            public string DocumentNumberCheckDigit { get; set; }
            public new string DocumentNumber { get { return String.Format("{0}{1}{2}{3}", CivilianIdNumber, CivilianIdNumberCheckDigit.ToString(), Version, DocumentNumberCheckDigit); }  }

            public static bool CheckCivilianIdNumber(string civilianIdNumber, int civilianIdNumberCheckDigit)
            {
                int checkDigit = 0;
                if (civilianIdNumber.Length != 8)
                    throw new ArgumentException("O número de identificação civil não tem o número de digitos correcto. Devem constar 8 digitos.");

                foreach (char character in civilianIdNumber)
                {
                    if (!Char.IsDigit(character))
                        throw new ArgumentException("O número de identificação civil só deve conter digitos.");
                }
                for (int i = civilianIdNumber.Length - 1 , j = 2; i >= 0; i--, j++)
                {
                    checkDigit += civilianIdNumber[i] * j;
                }
                checkDigit = checkDigit % 11;
                if (checkDigit == 1 || checkDigit == 0)
                    checkDigit = 0;
                else
                    checkDigit = 11 - checkDigit;

                return (checkDigit == civilianIdNumberCheckDigit);
            }

            public static bool CheckDocumentNumber(string documentNumber)
            {
                int checkDigit = 0;
                if (documentNumber.Length != 12)
                    throw new ArgumentException("O número de cartão de cidadão não tem o número de caracteres correcto. Devem constar 12 caracteres");
                for (int i = 0; i < documentNumber.Length; i++)
                {
                        int val = GetNumberFromChar(documentNumber[i]);
                    if (i == 0 || i%2 == 0)
                    {
                        val *= 2;
                        if (val >= 10)
                            val -= 9;
                    }
                    checkDigit += val;
                }
                return 0 == checkDigit % 10;

            }

            private static int GetNumberFromChar (char letter)
            {
                switch (letter)
                {
                    case '0': return 0;
                    case '1': return 1;
                    case '2': return 2;
                    case '3': return 3;
                    case '4': return 4;
                    case '5': return 5;
                    case '6': return 6;
                    case '7': return 7;
                    case '8': return 8;
                    case '9': return 9;
                    case 'A': return 10;
                    case 'B': return 11;
                    case 'C': return 12;
                    case 'D': return 13;
                    case 'E': return 14;
                    case 'F': return 15;
                    case 'G': return 16;
                    case 'H': return 17;
                    case 'I': return 18;
                    case 'J': return 19;
                    case 'K': return 20;
                    case 'L': return 21;
                    case 'M': return 22;
                    case 'N': return 23;
                    case 'O': return 24;
                    case 'P': return 25;
                    case 'Q': return 26;
                    case 'R': return 27;
                    case 'S': return 28;
                    case 'T': return 29;
                    case 'u': return 30;
                    case 'V': return 31;
                    case 'W': return 32;
                    case 'X': return 33;
                    case 'Y': return 34;
                    case 'Z': return 35;
                    default: throw new ArgumentException(String.Format("O caracter {0} não é válido para o número de Cartão de Cidadão", letter));
                }
            }

        }

        public class BilheteDeIdentidade : IdDocument
        {
            public int DocumentNumberCheckDigit { get; set; }
            public string IssuePlace { get; set;}
            /// <summary>
            /// Constructor do Bilhete de Identidade
            /// </summary>
            /// <param name="numero">Número do Bilhete de Identidade (sem o digito de controlo)</param>
            /// <param name="digitoDeControlo">Digito de controlo</param>
            /// <param name="issueDate">Data de Emissão</param>
            /// <param name="expiryDate">Data de Validade</param>
            /// <param name="issuePlace">Local de Emissão</param>
            public BilheteDeIdentidade(string numero, int digitoDeControlo, DateTime issueDate, DateTime expiryDate, string issuePlace)
            {
                if (numero.Length != 8)
                    throw new ArgumentException(String.Format("{0} não cumpre os requisitos de um número de bilhete de identidade. Deve conter oito digitos", numero));
                if (!CartaoDeCidadao.CheckCivilianIdNumber(numero, digitoDeControlo))
                    throw new ArgumentException(String.Format("{0} não parece ser um número válido quando confirmado com o digito de controlo {1}", numero, digitoDeControlo.ToString()));

                DocumentNumber = numero;
                IssueDate = issueDate;
                ExpiryDate = expiryDate;
                IssuePlace = issuePlace;
                IdDocumentType = DocumentType.BilheteDeIdentidade;
            }
            /// <summary>
            /// Constructor do Bilhete de Identidade
            /// </summary>
            /// <param name="numero">Número do Bilhete de Identidade com oito digitos (sem o digito de controlo)</param>
            /// <param name="digitoDeControlo">Digito de controlo</param>
            /// <param name="diaIssueDate">Dia da data de emissão</param>
            /// <param name="mesIssueDate">Mês da data de emissão</param>
            /// <param name="anoIssueDate">Ano da data de emissão</param>
            /// <param name="diaExpiryDate">Dia da data de validade</param>
            /// <param name="mesExpiryDate">Mês da data de validade</param>
            /// <param name="anoExpiryDate">Ano da data de validade</param>
            /// <param name="issuePlace">Local de emissão</param>
            public BilheteDeIdentidade(string numero, int digitoDeControlo, int diaIssueDate, int mesIssueDate, int anoIssueDate, int diaExpiryDate, int mesExpiryDate, int anoExpiryDate, string issuePlace)
                : this(numero, digitoDeControlo, new DateTime(anoIssueDate, mesIssueDate, diaIssueDate), new DateTime(anoExpiryDate, mesExpiryDate, diaExpiryDate), issuePlace)
            {
            }

        }

        public class BilheteDeIdentidadeMilitar : IdDocument
        {
            public Organismo Organismo { get; set; }
            public BilheteDeIdentidadeMilitar(string nr, DateTime expiryDate, Organismo organismo)
            {
                DocumentNumber = nr;
                ExpiryDate = expiryDate;
                Organismo = organismo;
                IdDocumentType = DocumentType.BilheteDeIdentidadeMilitar;
            }
        }
    }
}