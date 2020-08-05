using JustiCal.Model;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JustiCal
{
    public class ModelClass
    {
        View.ViewClass view;
        public static HttpClient client = new HttpClient(); //create a HttpClient
        private List<object> persons;


        public ModelClass(View.ViewClass v)
        {
            view = v;
            persons = new List<object>();
        }

        public void AddPerson(object person)
        {
            persons.Add(person);
        }

        public void PrintPersons()
        {
            int index = 1;
                Console.WriteLine("===PESSOAS===");
            foreach (object item in persons)
            {
                Person tmp = (Person)item;
                Console.WriteLine("-------------");
                Console.WriteLine(String.Format("{0} - {1}\nData de Nascimento: {2}/{3}/{4}", index, tmp.getFullName(), tmp.BirthDate.Value.Day, tmp.BirthDate.Value.Month, tmp.BirthDate.Value.Year));
                Console.WriteLine("-------------");
            }
        }
    }
}
