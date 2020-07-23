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
        List<object> persons;

        public ModelClass(View.ViewClass v)
        {
            view = v;
            persons = new List<object>();

            

            
        }
    }
}
