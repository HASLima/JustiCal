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
            private ModelClass model;
            private View.ViewClass view;

            public Controller()
            {
                View = new View.ViewClass(model);
                Model = new ModelClass(view);

                view.UtilizadorClicouEmSubmeterPessoa += PrecisoAdicionarIndividuo;
                view.UtilizadorClicouEmImprimirPessoas += PrecisoImprimirPessoas;
            }

            public ModelClass Model
            {
                get { return model; }
                set { model = value; }
            }

            public View.ViewClass View
            {
                get { return view; }
                set { view = value; }
            }

            private void PrecisoAdicionarIndividuo(object individuo)
            {
                model.AddPerson(individuo);
            }

            private void PrecisoImprimirPessoas()
            {
                model.PrintPersons();
            }




        }
    }

}
