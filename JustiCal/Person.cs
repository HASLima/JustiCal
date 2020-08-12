using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustiCal
{
    namespace Model
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string OtherNames { get; set; }
            public DateTime? BirthDate { get; set; }
            public List<object> IdDocuments { get; set; }
            public bool Masculino { get; set; }
            public List<Morada> Moradas { get; set; }
            public List<ContactoTelefonico> Contactos { get; set; }
            public List<EnderecoElectronico> Emails { get; set; }
            public string[] Filiacao;
            public string Naturalidade { get; set; }
            public string Nacionalidade { get; set; }
            /// <summary>
            /// Constructor for the Person class
            /// </summary>
            /// <param name="name">Full Name</param>
            /// <param name="masculino">True if male, False if Female</param>
            /// <param name="idDocuments">A list of IdDocuments</param>
            /// <param name="birthDate">The birthdate</param>
            /// <param name="moradas">A list of addresses</param>
            /// <param name="contactos">A list of contacts</param>
            /// <param name="mailAddress">The email address</param>
            /// <param name="pai">Father's Fullname</param>
            /// <param name="mae">Mother's Fullname</param>
            /// <param name="naturalidade">Naturality</param>
            /// <param name="nacionalidade">Nacionality</param>
            public Person(string name, bool masculino, List<object> idDocuments = null, DateTime? birthDate = null, List<Morada> moradas = null, List<ContactoTelefonico> contactos = null, List<EnderecoElectronico> mails = null, string pai = null, string mae = null , string naturalidade = null, string nacionalidade = null)
            {
                //Spliting FirstName, LastName and other names from name
                string[] names = name.Split(' ');
                FirstName = names[0];
                if (names.Length > 1)
                    LastName = names[names.Length - 1];
                if (names.Length > 2)
                {
                    OtherNames = names[1];
                    for (int i = 2; i < names.Length - 1; i++)
                    {
                        OtherNames += " " + names[i];
                    }
                }

                Masculino = masculino;

                if (!(idDocuments == null))
                    IdDocuments = idDocuments;
                else
                    IdDocuments = new List<object>();

                if (!(birthDate == null))
                    BirthDate = birthDate;
                if (!(moradas == null))
                    Moradas = moradas;
                else
                    Moradas = new List<Morada>();
                if (!(contactos == null))
                    Contactos = contactos;
                else
                    Contactos = new List<ContactoTelefonico>();
                if (!(mails == null))
                    Emails = mails;
                else
                    Emails = new List<EnderecoElectronico>();
                Filiacao = new string[] { pai, mae };
                if (!(naturalidade == null))
                    Naturalidade = naturalidade;
                if (!(nacionalidade == null))
                    Nacionalidade = nacionalidade;
            }
            /// <summary>
            /// Uses FirstName, LastName and OtherNames to return the Person's full name
            /// </summary>
            /// <returns>The Person's FullName</returns>
            public string getFullName()
            {
                if (OtherNames != string.Empty)
                    return FirstName + " " + OtherNames + " " + LastName;
                else
                    return FirstName + " " + LastName;
            }
            public string GetOneDocument()
            {
                if (IdDocuments.Count < 1)
                    return String.Format("N/A"); //TODO arranjar uma excepção
                else if (IdDocuments.Count == 1)
                    return IdDocuments[0].ToString();
                else
                {
                    IdDocument idDocument = (IdDocument)IdDocuments[0];
                    foreach (IdDocument item in IdDocuments)
                    {
                        if (item.IdDocumentType < idDocument.IdDocumentType)
                        {
                            idDocument = (IdDocument)item;
                        }
                    }
                    return idDocument.ToString();
                }
            }

        }

        public class Militar : Person
        {
            public string Posto { get; set; }
            public string Arma { get; set; }
            public string Nr { get; set; }


            public Militar(string posto, string arma, string nr, Person person) : base(person.getFullName(), person.Masculino, person.IdDocuments, person.BirthDate, person.Moradas, person.Contactos, person.Emails, person.Filiacao[0], person.Filiacao[1], person.Naturalidade, person.Nacionalidade)
            {
                Posto = posto;
                Arma = arma;
                Nr = nr;
            }

            public virtual string NormalizedPrint()
            {
                string normalizedprint = Posto;
                if (Arma != null)
                    normalizedprint += " de " + Arma;
                if (Nr != null)
                {
                    if (Nr.Length == 8)
                        normalizedprint += " NM " + Nr;
                    if (Nr.Length == 9)
                        normalizedprint += " NIM " + Nr;
                }
                normalizedprint += " - " + getFullName();
                return normalizedprint;
            }
        }

        public class Student : Militar
        {
            private int nrCorpo;
            private string curso;
            private int companhia;
            private int batalhao;
            private string origem;
            public Student(int nrCorpo, string curso, int companhia, int batalhao, string origem, Militar militar) : base (militar.Posto, militar.Arma, militar.Nr, militar)
            {
                NrCorpo = nrCorpo;
                Curso = curso;
                Companhia = companhia;
                Batalhao = batalhao;
                Origem = origem;
            }

            public int NrCorpo
            {
                get { return nrCorpo; }
                set { nrCorpo = value; }
            }

            public string Curso
            {
                get { return curso; }
                set { curso = value; }
            }

            public int Companhia
            {
                get { return companhia; }
                set { companhia = value; }
            }

            public int Batalhao
            {
                get { return batalhao; }
                set { batalhao = value; }
            }

            public string Origem
            {
                get { return origem; }
                set { origem = value; }
            }

            public override string NormalizedPrint()
            {
                string normalizedprint = Posto;
                if (Arma != null && (Posto == "Aspirante-Aluno" || Posto == "Alferes-Aluno" || Posto == "Tenente-Aluno"))
                    normalizedprint += " de " + Arma;
                if (Origem == "PLOP")
                    normalizedprint += " n.º " + NrCorpo + "/PLOP";
                else
                    normalizedprint += " n.º " + NrCorpo;
                if (Nr != null)
                {
                    if (Nr.Length == 8)
                        normalizedprint += " NM " + Nr;
                    if (Nr.Length == 9)
                        normalizedprint += " NIM " + Nr;
                }
                normalizedprint += " - " + getFullName();
                return normalizedprint;
            }


        }

        public class OficialInstrutor
        {
            private Militar militar;
            private DateTime inicialDate;
            private DateTime finalDate;

            public OficialInstrutor(Militar militar, DateTime inicialDate, DateTime? finalDate = null)
            {
                Militar = militar;
                InicialDate = inicialDate;
                if (finalDate != null)
                    FinalDate = (DateTime)finalDate;
            }

            public Militar Militar
            {
                get { return militar; }
                set { militar = value; }
            }

            public DateTime InicialDate
            {
                get { return inicialDate; }
                set { inicialDate = value; }
            }

            public DateTime FinalDate
            {
                get { return finalDate; }
                set { finalDate = value; }
            }
        }
    }
}
