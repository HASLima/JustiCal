using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    static class JustiCal
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Person oPerson;
            oPerson = new Person("Hélder Alexandre de Sousa Lima");
            MessageBox.Show(oPerson.FirstName);
            MessageBox.Show(oPerson.OtherNames);
            MessageBox.Show(oPerson.LastName);
            MessageBox.Show(oPerson.getFullName());
        }
    }
}
