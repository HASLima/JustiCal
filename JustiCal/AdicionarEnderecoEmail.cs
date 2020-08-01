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
    public partial class AdicionarEnderecoEmail : Form
    {
        public AdicionarEnderecoEmail()
        {
            InitializeComponent();
        }

        public object eMail;

        private void submeterButton_Click(object sender, EventArgs e)
        {
            eMail = new EnderecoElectronico(descricaoTextBox.Text, enderecoTextBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AdicionarEnderecoEmailToolTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
