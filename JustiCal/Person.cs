using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustiCal
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            OtherNames = string.Empty;
            LastName = lastName;
        }

        public Person (string firstName, string otherNames, string lastName)
        {
            FirstName = firstName;
            OtherNames = otherNames;
            LastName = lastName;
        }

        public string getFullName()
        {
            if (otherNames != string.Empty)
                return FirstName + " " + OtherNames + " " + LastName;
            else
                return FirstName + " " + LastName;
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

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        private DateTime birthDate;

        // TODO acrescentar documento de identificação
    }
}
