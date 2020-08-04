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
    public partial class AdicionarContactoTelefonico : Form
    {
        public AdicionarContactoTelefonico()
        {
            InitializeComponent();
        }
        public ContactoTelefonico contacto;
        private List<string> descricoes = new List<string>() { "Principal", "Emergência", "Fixo", "Móvel"};


        private void AdicionarContactoTelefonico_Load(object sender, EventArgs e)
        {
            descricaoComboBox.Items.AddRange(descricoes.ToArray());
            indicativoTextBox.Text = "+351";
            
        }

        private void indicativoTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void submeterButton_Click(object sender, EventArgs e)
        {
            contacto = new ContactoTelefonico(numeroTextBox.Text, descricaoComboBox.Text, detentorTextBox.Text, indicativoTextBox.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void plusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
