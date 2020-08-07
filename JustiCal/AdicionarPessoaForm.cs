using JustiCal.Model;
using JustiCal.View;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    namespace View
    {
        public partial class AdicionarPessoaForm : Form
        {
            private ViewClass view;
            public AdicionarPessoaForm(ViewClass v)
            {
                view = v;
                InitializeComponent();
            }

            List<object> listaDeDocumentos = new List<object>();
            List<EnderecoElectronico> listaDeMails = new List<EnderecoElectronico>();
            List<Morada> listaDeMoradas = new List<Morada>();
            List<ContactoTelefonico> listaDeContactosTelefonicos = new List<ContactoTelefonico>();
            public object individuo;
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
                Debug.WriteLine(String.Format("listaDeMoradas.Count = {0}", listaDeMoradas.Count));
            }

            private void refreshContactosTelefonicosListBox()
            {
                contactosTelefonicosListBox.Items.Clear();
                foreach (ContactoTelefonico item in listaDeContactosTelefonicos)
                {
                    contactosTelefonicosListBox.Items.Add(item);
                }
                Debug.WriteLine(String.Format("listaDeContactosTelefonicos = {0}", listaDeContactosTelefonicos.Count));
            }



            private void AdicionarPessoaForm_Load(object sender, EventArgs e)
            {
                birthDateDateTimePicker.MaxDate = DateTime.Now;
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
                bool masculino = (masculinoRadioButton.Checked && !femininoRadioButton.Checked);
                Person pessoa = new Person(fullNameTextBox.Text, masculino, listaDeDocumentos, birthDateDateTimePicker.Value, listaDeMoradas, listaDeContactosTelefonicos, listaDeMails, filiacao1TextBox.Text, filiacao2TextBox.Text, naturalidadeComboBox.Text, nacionalidadeComboBox.Text);
                if (pessoa == null)
                {
                    Debug.WriteLine("pessoa é nulo");
                }
                if (militarCheckBox.Checked)
                {
                    Militar militar = new Militar(postoComboBox.Text, armaComboBox.Text, nrTextBox.Text, pessoa);
                    if (alunoCheckBox.Checked)
                    {
                        int bat = 0;
                        if (companhiaComboBox.SelectedIndex > 3)
                        {
                            bat = 2;
                        }
                        else
                        {
                            bat = 1;
                        }
                        Int32.TryParse(nrCorpoTextBox.Text, out int nrCorpo);
                        Student student = new Student(nrCorpo, cursoComboBox.Text, companhiaComboBox.SelectedIndex, bat, origemComboBox.Text, militar);
                        individuo = student;
                        view.CliqueEmSubmeterPessoa(individuo);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        individuo = militar;
                        view.CliqueEmSubmeterPessoa(individuo);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    individuo = pessoa;
                    view.CliqueEmSubmeterPessoa(individuo);
                    if (individuo == null)
                    {
                        Debug.WriteLine("individuo é nulo");
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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
                    birthDateDateTimePicker.Font = new System.Drawing.Font("Lucida Console", 10, FontStyle.Strikeout, GraphicsUnit.Point);
                    e.Cancel = true;
                }
                else
                    birthDateDateTimePicker.Font = new System.Drawing.Font("Lucida Console", 10, FontStyle.Regular, GraphicsUnit.Point);

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
                AdicionarMorada adicionarMorada = new AdicionarMorada(view);
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
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    moradasListBox.Items.Remove(list[i]);
                    listaDeMails.RemoveAt(i);
                }
                refreshAddressesListBox();
            }

            private void criarContactoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AdicionarContactoTelefonico adicionarContactoForm = new AdicionarContactoTelefonico();
                DialogResult dialogResult = adicionarContactoForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    listaDeContactosTelefonicos.Add(adicionarContactoForm.contacto as ContactoTelefonico);
                }
                refreshContactosTelefonicosListBox();
            }

            private void apagarContactoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ListBox.SelectedObjectCollection list = contactosTelefonicosListBox.SelectedItems;
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    contactosTelefonicosListBox.Items.Remove(list[i]);
                    listaDeContactosTelefonicos.RemoveAt(i);
                }
                refreshContactosTelefonicosListBox();
            }

            private void masculinoRadioButton_CheckedChanged(object sender, EventArgs e)
            {
                if ((masculinoRadioButton.Checked && !femininoRadioButton.Checked) || (!masculinoRadioButton.Checked && femininoRadioButton.Checked))
                {

                }
            }
        } 
    }
}
