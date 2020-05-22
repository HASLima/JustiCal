using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustiCal
{
    public class Person
    {
        private bool masculino;
        public Person(string name, bool masculino, IdDocument idDocument = null, DateTime? birthDate = null)
        {
            string[] names = name.Split(' ');
            FirstName = names[0];
            if (names.Length > 1)
                LastName = names[names.Length - 1];
            if (names.Length > 2)
            {
                OtherNames = names[1];
                for (int i = 2; i < names.Length-1; i++)
                {
                    OtherNames += " " + names[i];
                }
            }
            Masculino = masculino;
            if (!(idDocument == null))
                IdDocument = idDocument;
            if (!(birthDate == null))
                BirthDate = birthDate;
        }

        public Person (string firstName, string otherNames, string lastName, bool masculino, IdDocument idDocument = null, DateTime? birthDate = null)
        {
            FirstName = firstName;
            OtherNames = otherNames;
            LastName = lastName;
            Masculino = masculino;
            if (!(idDocument == null))
                IdDocument = idDocument;
            if (!(birthDate == null))
                BirthDate = birthDate;
        }

        public string getFullName()
        {
            if (otherNames != string.Empty)
                return FirstName + " " + OtherNames + " " + LastName;
            else
                return FirstName + " " + LastName;
        }

        public bool Masculino
        {
            get { return masculino; }
            set { masculino = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string firstName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string lastName;

        public string OtherNames
        {
            get { return otherNames; }
            set { otherNames = value; }
        }
        private string otherNames;

        public DateTime? BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        private DateTime? birthDate;

        public IdDocument IdDocument
        {
            get { return idDocument; }
            set { idDocument = value; }
        }
        private IdDocument idDocument;
    }

    public class Militar : Person
    {
        private string posto;
        private string arma;
        private string nr;

        public Militar(string posto, string arma, string nr, string firstName, string otherNames, string lastName, bool masculino, IdDocument idDocument = null, DateTime? birthDate = null) : base (firstName, otherNames, lastName, masculino, idDocument, birthDate)
        {
            Posto = posto;
            Arma = arma;
            Nr = nr;
        }

        public Militar(string posto, string arma, string nr, string name, bool masculino, IdDocument idDocument = null, DateTime? birthDate = null): base (name, masculino, idDocument, birthDate)
        {
            Posto = posto;
            Arma = arma;
            Nr = nr;
        }

        public string Posto
        {
            get { return posto; }
            set { posto = value; }
        }

        public string Arma
        {
            get { return arma; }
            set { arma = value; }
        }

        public string Nr
        {
            get { return nr; }
            set { nr = value; }
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
        public Student (int nrCorpo, string curso, int companhia, int batalhao, string origem, string posto, string arma, string nr, string name, bool masculino, IdDocument idDocument = null, DateTime? birthDate = null): base (posto, arma, nr, name, masculino, idDocument, birthDate)
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
