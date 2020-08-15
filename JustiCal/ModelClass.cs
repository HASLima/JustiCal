using JustiCal.Model;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JustiCal
{
    namespace Model
    {
        public class ModelClass
        {
            View.ViewClass view;
            public static HttpClient client = new HttpClient(); //create a HttpClient

            public Academia Academia { get; set; }
            public List<object> Persons { get; private set; }

            public ModelClass(View.ViewClass v)
            {
                view = v;
                Persons = new List<object>();

                //Só para testes
                Academia.Pessoas.Add(new Person("Hélder Alexandre de Sousa Lima", true, new List<object>() { new CartaoDeCidadao("133683761ZX8", new DateTime(2021, 10, 21)) }, new DateTime(1988, 03, 02), new List<Morada>() { new Morada("Principal", "Rua", "Dias Lourenço", "10", null, "2925", "135") }));
                //
            }


            public void AddPerson(object person)
            {
                Academia.Pessoas.Add(person);
            }

            public void deletePerson(object person)
            {
                Debug.Write(String.Format("Antes de Apagar: {0}", Academia.Pessoas.Count));
                Academia.Pessoas.Remove(person);
                Debug.WriteLine(String.Format("Depois de Apagar: {0}", Academia.Pessoas.Count));
            }

            public void PrintPersons()
            {
                int index = 1;
                Console.WriteLine("===PESSOAS===");
                foreach (object item in Academia.Pessoas)
                {
                    Person tmp = (Person)item;
                    Console.WriteLine("-------------");
                    Console.WriteLine(String.Format("{0} - {1}\nData de Nascimento: {2}/{3}/{4}", index, tmp.getFullName(), tmp.BirthDate.Value.Day, tmp.BirthDate.Value.Month, tmp.BirthDate.Value.Year));
                    Console.WriteLine("-------------");
                }
            }

        } 
    }
}
