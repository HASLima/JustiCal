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
        List<EnderecoElectronico> listaDeMails = new List<EnderecoElectronico>();
        List<Morada> listaDeMoradas = new List<Morada>();
        /// <summary>
        /// Apaga e volta a preencher os items da IdDocumentsListBox
        /// </summary>
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
            Debug.WriteLine(String.Format("listaDeDcoumentos.Count = {0}", listaDeDocumentos.Count));
        }

        private void refreshEmailAddressesListBox()
        {
            emailsListBox.Items.Clear();
            foreach (EnderecoElectronico item in listaDeMails)
            {
                emailsListBox.Items.Add(String.Format("{0} [{1}]", item.Descricao, item.Address));
            }
            Debug.WriteLine(String.Format("listaDeMails.Count = {0}", listaDeMails.Count));
        }

        private void refreshAddressesListBox()
        {
            moradasListBox.Items.Clear();
            foreach (Morada item in listaDeMoradas)
            {
                moradasListBox.Items.Add(item);
            }
            Debug.WriteLine(String.Format("listaDeMoradas.Count = {0}", listaDeMails.Count));
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
            for (int i = list.Count - 1; i >= 0; i--)
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

        private void birthDateDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (birthDateDateTimePicker.Value > DateTime.Now)
            {
                birthDateDateTimePicker.Font = new Font("Lucida Console", 10, FontStyle.Strikeout, GraphicsUnit.Point);
                e.Cancel = true;
            }
            else
                birthDateDateTimePicker.Font = new Font("Lucida Console", 10, FontStyle.Regular, GraphicsUnit.Point);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            alunoCheckBox.Visible = militarCheckBox.Checked;
            alunoCheckBox.Enabled = militarCheckBox.Checked;
            if (!militarCheckBox.Checked)
            {
                alunoCheckBox.Checked = false;
            }

            postoLabel.Visible = militarCheckBox.Checked;
            postoLabel.Enabled = militarCheckBox.Checked;
            postoComboBox.Visible = militarCheckBox.Checked;
            postoComboBox.Enabled = militarCheckBox.Checked;

            armaLabel.Visible = militarCheckBox.Checked;
            armaLabel.Enabled = militarCheckBox.Checked;
            armaComboBox.Visible = militarCheckBox.Checked;
            armaComboBox.Enabled = militarCheckBox.Checked;

            nrLabel.Visible = militarCheckBox.Checked;
            nrLabel.Enabled = militarCheckBox.Checked;
            nrTextBox.Visible = militarCheckBox.Checked;
            nrTextBox.Enabled = militarCheckBox.Checked;
        }

        private void criarEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarEnderecoEmail adicionarEnderecoEmail = new AdicionarEnderecoEmail();
            DialogResult result = adicionarEnderecoEmail.ShowDialog();
            if (result == DialogResult.OK)
            {
                listaDeMails.Add(adicionarEnderecoEmail.eMail as EnderecoElectronico);
            }
            refreshEmailAddressesListBox();
        }

        private void apagarEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection list = emailsListBox.SelectedItems;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                emailsListBox.Items.Remove(list[i]);
                listaDeMails.RemoveAt(i);
            }
            refreshEmailAddressesListBox();
        }

        private void alunoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nrCorpoLabel.Visible =
                nrCorpoLabel.Enabled =
                nrCorpoTextBox.Visible =
                nrCorpoTextBox.Enabled = alunoCheckBox.Checked;

            cursoLabel.Visible =
                cursoLabel.Enabled =
                cursoComboBox.Visible =
                cursoComboBox.Enabled = alunoCheckBox.Checked;

            companhiaLabel.Visible =
                companhiaLabel.Enabled =
                companhiaComboBox.Visible =
                companhiaComboBox.Enabled = alunoCheckBox.Checked;

            origemLabel.Visible =
                origemLabel.Enabled =
                origemComboBox.Visible =
                origemComboBox.Enabled = alunoCheckBox.Checked;


        }

        private void moradasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criarMoradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarMorada adicionarMorada = new AdicionarMorada();
            DialogResult dialogResult = adicionarMorada.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                listaDeMoradas.Add(adicionarMorada.morada as Morada);
            }
            refreshAddressesListBox();
        }

        private void apagarMoradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection list = moradasListBox.SelectedItems;
            for (int i = list.Count -1; i >= 0; i--)
            {
                moradasListBox.Items.Remove(list[i]);
                listaDeMails.RemoveAt(i);
            }
            refreshAddressesListBox();
        }
    }
}
