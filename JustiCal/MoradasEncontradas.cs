using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    namespace View
    {
        public partial class MoradasEncontradas : Form
        {
            public int escolha;
            public MoradasEncontradas(List<string[]> listaDeMoradas)
            {
                InitializeComponent();
                foreach (string[] item in listaDeMoradas)
                {
                    moradasEncontradasListBox.Items.Add(String.Format("{0} {1}, {2}", item[0], item[1], item[3]));
                }
            }

            private void moradasEncontradasListBox_DoubleClick(object sender, EventArgs e)
            {
                escolha = moradasEncontradasListBox.SelectedIndex;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        } 
    }
}
