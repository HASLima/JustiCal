﻿using JustiCal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        List<object> listaDeDocumentos = new List<object>();

        private void refreshIdDocumentsListBox()
        {
            IdDocumentsListBox.Items.Clear();
            foreach (object item in listaDeDocumentos)
            {
                if (item is CartaoDeCidadao)
                {
                    CartaoDeCidadao cartao = item as CartaoDeCidadao;
                IdDocumentsListBox.Items.Add(String.Format("CC {0}", cartao.DocumentNumber));
                }
                else if (item is BilheteDeIdentidade)
                {
                    BilheteDeIdentidade bilhete = item as BilheteDeIdentidade;
                    IdDocumentsListBox.Items.Add(String.Format("BI {0}", bilhete.DocumentNumber));
                }
            }
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
                IdDocumentsListBox.Items.Add(item);
            }
        }

        private void apagarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection list = IdDocumentsListBox.SelectedItems;
            for (int i = list.Count-1;  i >= 0; i--)
            {
                IdDocumentsListBox.Items.Remove(list[i]);
                listaDeDocumentos.RemoveAt(i);
            }
            refreshIdDocumentsListBox();
        }

        private void cartãoDeCidadãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarCartaoDeCidadao adicionarCartaoDeCidadaoForm = new AdicionarCartaoDeCidadao();
            DialogResult result = adicionarCartaoDeCidadaoForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Debug.WriteLine("Teste");
                listaDeDocumentos.Add(adicionarCartaoDeCidadaoForm.cartao);
            }
            refreshIdDocumentsListBox();
        }
    }
}
