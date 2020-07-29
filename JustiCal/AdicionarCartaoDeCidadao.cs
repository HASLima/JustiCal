using JustiCal.Model;
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
    public partial class AdicionarCartaoDeCidadao : Form
    {
        public AdicionarCartaoDeCidadao()
        {
            InitializeComponent();
        }

        public object cartao;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nrLabel_Click(object sender, EventArgs e)
        {

        }

        private void nrTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void nrTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CartaoDeCidadao.CheckDocumentNumber(nrTextBox.Text)) //verificar se o nr do Cartão é válido
            {
                nrTextBox.BackColor = Color.Green; //se for válido passa a ter fundo verde
                submitButton.Enabled = true;        // e o botão passa a estar válido
            }
            else
            {
                nrTextBox.BackColor = Color.Red; //se não for válido passa a ter fundo vermelho
                submitButton.Enabled = false;   //desactiva o botão de submeter
                e.Cancel = true; //não permite a saida do controlo
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            cartao = new CartaoDeCidadao(nrTextBox.Text, expiryDateDateTimePicker.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
