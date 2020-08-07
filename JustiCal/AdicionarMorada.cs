using JustiCal.Model;
using JustiCal.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    namespace View
    {
        public partial class AdicionarMorada : Form
        {
            public object morada;
            private ViewClass view;
            public AdicionarMorada(ViewClass v)
            {
                InitializeComponent();
                view = v;
            }

            private void AdicionarMorada_Load(object sender, EventArgs e)
            {
                countryComboBox.Items.AddRange(Morada.CountryList().ToArray());
                countryComboBox.Text = "Portugal";
            }

            private void cp4TextBox_Validating(object sender, CancelEventArgs e)
            {
                if (Morada.CP4IsValid(cp4TextBox.Text))
                {
                    cp4TextBox.BackColor = Color.Green;
                    e.Cancel = false;
                }
                else
                {
                    cp4TextBox.BackColor = Color.Red;
                    e.Cancel = true;
                }
            }

            private void cp3TextBox_Validating(object sender, CancelEventArgs e)
            {
                if (Morada.CPIsValid(cp4TextBox.Text, cp3TextBox.Text))
                {
                    cp4TextBox.BackColor = cp3TextBox.BackColor = Color.Green;
                    findAddressButton.Enabled = true;
                    e.Cancel = false;
                }
                else
                {
                    cp3TextBox.BackColor = Color.Red;
                    findAddressButton.Enabled = false;
                    e.Cancel = true;
                }
            }

            private void countryComboBox_Validating(object sender, CancelEventArgs e)
            {
                if (countryComboBox.Text == "Portugal")
                {
                    cp3TextBox.Enabled = cp3TextBox.Visible = (countryComboBox.Text == "Portugal");
                    designacaoPostalTextBox.Enabled = !(countryComboBox.Text == "Portugal");
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                List<string[]> moradasEncontradas = view.CliqueEmProcurarCP(cp4TextBox.Text, cp3TextBox.Text);

                if (moradasEncontradas.Count == 1)
                {
                    arteriaTextBox.Text = moradasEncontradas[0][0];
                    nomeDaArteriaTextBox.Text = moradasEncontradas[0][1];
                    localidadeTextBox.Text = moradasEncontradas[0][2];
                    designacaoPostalTextBox.Text = moradasEncontradas[0][3];
                }
                else if (moradasEncontradas.Count > 1)
                {
                    MoradasEncontradas moradasEncontradasForm = new MoradasEncontradas(moradasEncontradas);
                    DialogResult dialogResult = moradasEncontradasForm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        arteriaTextBox.Text = moradasEncontradas[moradasEncontradasForm.escolha][0];
                        nomeDaArteriaTextBox.Text = moradasEncontradas[moradasEncontradasForm.escolha][1];
                        localidadeTextBox.Text = moradasEncontradas[moradasEncontradasForm.escolha][2];
                        designacaoPostalTextBox.Text = moradasEncontradas[moradasEncontradasForm.escolha][3];
                    }
                }
            }

            private void submeterButton_Click(object sender, EventArgs e)
            {
                morada = new Morada(descricaoTextBox.Text, arteriaTextBox.Text, nomeDaArteriaTextBox.Text, portaTextBox.Text, alojamentoTextBox.Text, cp4TextBox.Text, cp3TextBox.Text, countryComboBox.Text, localidadeTextBox.Text, designacaoPostalTextBox.Text);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        } 
    }
}
