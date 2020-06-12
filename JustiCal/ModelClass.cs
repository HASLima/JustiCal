using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustiCal
{
    public class ModelClass
    {
        View.ViewClass view;

        public ModelClass(View.ViewClass v)
        {
            view = v;
        }
    }
}
