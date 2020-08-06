using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    namespace View
    {
        public class ViewClass
        {
            private Form homepage;
            ModelClass model;

            public delegate void UtilizadorClicarEmSubmeterPessoa(object Individuo);
            public event UtilizadorClicarEmSubmeterPessoa UtilizadorClicouEmSubmeterPessoa;

            public delegate void UtilizadorClicarEmImprimirPessoas();
            public event UtilizadorClicarEmImprimirPessoas UtilizadorClicouEmImprimirPessoas;

            public delegate List<string[]> UtilizadorClicarEmProcurarCodigoPostal(string cp4, string cp3);
            public event UtilizadorClicarEmProcurarCodigoPostal UtilizadorClicouEmProcurarCodigoPostal;

            public ViewClass(ModelClass m)
            {
                model = m;
            }

            /// <summary> Activar UI cria o interface gráfico
            /// <para>Abre uma janela que será a "homepage" para toda a aplicação.</para>
            /// </summary>
            public void ActivarUI()
            {
                homepage = new Form1(this);
                homepage.ShowDialog();
            }

            public void CliqueEmSubmeterPessoa(object individuo)
            {
                UtilizadorClicouEmSubmeterPessoa(individuo);
            }

            public void CliqueEmImprimirPessoas()
            {
                UtilizadorClicouEmImprimirPessoas();
            }

            public List<string[]> CliqueEmProcurarCP(string cp4, string cp3)
            {
                return UtilizadorClicouEmProcurarCodigoPostal(cp4, cp3);
            }
        } 
    }
}
