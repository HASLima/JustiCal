using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    namespace Controller
    {
        class Controller
        {
            private Model model;
            private View view;

            public Controller()
            {
                View = new View(model);
                Model = new Model(view);
            }

            public Model Model
            {
                get { return model; }
                set { model = value; }
            }

            public View View
            {
                get { return view; }
                set { view = value; }
            }




        }
    }

}
