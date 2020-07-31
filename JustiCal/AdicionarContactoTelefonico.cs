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

        public List<string> descricoes = new List<string>() { "Principal", "Emergência", "Fixo", "Móvel"};

        private void AdicionarContactoTelefonico_Load(object sender, EventArgs e)
        {
            descricaoComboBox.Items.AddRange(descricoes.ToArray());
            indicativoTextBox.Text = "+351";
        }

        private void indicativoTextBox_Leave(object sender, EventArgs e)
        {

        }
    }
}
