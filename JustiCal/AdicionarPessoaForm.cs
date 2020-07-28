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
    public partial class AdicionarPessoaForm : Form
    {
        public AdicionarPessoaForm()
        {
            InitializeComponent();
        }

        private void AdicionarPessoaForm_Load(object sender, EventArgs e)
        {

        }

        private void birthDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void birthDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string> { "133683761ZX8", "2080018", "16083006" };
            foreach (string item in strings)
            {
                listBox1.Items.Add(item);
            }
        }

        private void apagarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection list = listBox1.SelectedItems;
            for (int i = list.Count-1;  i >= 0; i--)
            {
                listBox1.Items.Remove(list[i]);
            }
            //ListBox.SelectedIndexCollection list = listBox1.SelectedIndices;
            //List<int> indexes = list.Cast<int>().ToList();
            //foreach (int item in indexes)
            {
            }
        }
    }
}
