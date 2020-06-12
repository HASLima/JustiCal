using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    public class View
    {
        private Form homepage;
        ModelClass model;

        public View(ModelClass m)
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
    }
}
