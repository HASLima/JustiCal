using JustiCal.Model;
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
                view.UtilizadorClicouEmProcurarCodigoPostal += PrecisoMoradas;
                view.UtilizadorSolicitouListaDePessoas += PrecisoPessoas;
                view.UtilizadorClicouEmApagarPessoa += PrecisoApagarPessoa; 

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

            private List<string[]> PrecisoMoradas(string cp4, string cp3)
            {
                return Morada.ProcurarCP(cp4, cp3);
            }

            private List<object> PrecisoPessoas()
            {
                return model.Academia.Pessoas;
            }

            private void PrecisoApagarPessoa(object individuo)
            {
                model.deletePerson(individuo);
            }




        }
    }

}
