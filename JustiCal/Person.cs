﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustiCal
{
    public class Person
    {
        public Person(string name, IdDocument idDocument = null, DateTime? birthDate = null)
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
            if (!(idDocument == null))
                IdDocument = idDocument;
            if (!(birthDate == null))
                BirthDate = birthDate;
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
        private string nim;

        public Militar(string posto, string arma, string nim, string firstName, string otherNames, string lastName): base (firstName, otherNames, lastName)
        {
            FirstName = firstName;
            OtherNames = otherNames;
            LastName = lastName;
        }
    }
}
