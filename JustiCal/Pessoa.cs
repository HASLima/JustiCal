using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustiCal
{
    public class Pessoa
    {
        public Pessoa()
        {

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
    }
}
