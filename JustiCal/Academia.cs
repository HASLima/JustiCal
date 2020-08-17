using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustiCal
{
    namespace Model
    {
        [Serializable]
        public class Academia
        {
            public List<object> Pessoas;
            public List<object> Processos;

            public Academia()
            {
                Pessoas = new List<object>();
                Processos = new List<object>();
            }
        } 
    }
}
