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
    public partial class AdicionarMorada : Form
    {
        public AdicionarMorada()
        {
            InitializeComponent();
        }

        private void AdicionarMorada_Load(object sender, EventArgs e)
        {
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
                e.Cancel = false;
            }
                else
                {
                    cp3TextBox.BackColor = Color.Red;
                e.Cancel = true;
                }
        }

        private void countryComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (countryComboBox.Text == "Portugal")
            {
                cp3TextBox.Enabled = cp3TextBox.Visible = (countryComboBox.Text == "Portugal");
                designacaoFiscalTextBox.Enabled = !(countryComboBox.Text == "Portugal");
            }
        }
    }
}
