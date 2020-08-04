using JustiCal.Model;
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
    public partial class AdicionarMorada : Form
    {
        public object morada;
        public AdicionarMorada()
        {
            InitializeComponent();
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
            if(Morada.CPIsValid(cp4TextBox.Text, cp3TextBox.Text))
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
            List<string[]> moradasEncontradas = new List<string[]>();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "JustiCal.Properties.todos_cp.txt";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new System.IO.StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (values[14] == cp4TextBox.Text && values[15] == cp3TextBox.Text)
                    {
                        string[] morada = new string[4];
                        morada[0] = values[5];
                        
                        morada[1] = values[6];
                        for (int i = 7; i < 10; i++)
                        {
                            if (values[i].Length > 0)
                            {
                                morada[1] += " " + values[i];
                            }
                        }
                        Debug.WriteLine(morada[1]);

                        morada[2] = values[3];

                        morada[3] = values[16];

                        moradasEncontradas.Add(morada);
                    }
                }
            }
            if (moradasEncontradas.Count==1)
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
