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
    namespace View
    {
        public partial class AdicionarBilheteDeIdentidade : Form
        {
            public BilheteDeIdentidade bilhete;
            public AdicionarBilheteDeIdentidade()
            {
                InitializeComponent();
            }

            private void CheckSubmitButton()
            {
                bool check = true;
                if (CivilianNumberTextBox.BackColor != Color.Green)
                    check = false;
                else if (IssueDateDateTimePicker.Value > DateTime.Now)
                    check = false;
                else if (expiryDateDateTimePicker.Value < DateTime.Now)
                    check = false;
                else if (IssuePlaceTextBox.Text.Length < 3)
                    check = false;
                submitButton.Enabled = check;
            }
            private void CheckDigitTextBox_Validating(object sender, CancelEventArgs e)
            {

                if (CivilianNumberTextBox.Text.Length == 0)
                {
                    CheckDigitTextBox.Text = "";
                    submitButton.Enabled = false;
                }
                else if (Int32.TryParse(CheckDigitTextBox.Text, out int checkDigit))
                {
                    if (CartaoDeCidadao.CheckCivilianIdNumber(CivilianNumberTextBox.Text, checkDigit))
                    {
                        CivilianNumberTextBox.BackColor = CheckDigitTextBox.BackColor = Color.Green;
                        submitButton.Enabled = true;
                    }
                    else
                    {
                        CivilianNumberTextBox.BackColor = CheckDigitTextBox.BackColor = Color.Red;
                        submitButton.Enabled = false;
                        e.Cancel = true;
                    }
                }
                else
                {
                    CivilianNumberTextBox.BackColor = CheckDigitTextBox.BackColor = SystemColors.Window;
                    submitButton.Enabled = false;
                    e.Cancel = false;
                }
            }

            private void submitButton_Click(object sender, EventArgs e)
            {
                Int32.TryParse(CheckDigitTextBox.Text, out int checkDigit);
                bilhete = new BilheteDeIdentidade(CivilianNumberTextBox.Text, checkDigit, IssueDateDateTimePicker.Value, expiryDateDateTimePicker.Value, IssuePlaceTextBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
