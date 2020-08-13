using JustiCal.Model;
using JustiCal.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustiCal
{
    public partial class HomePage : Form
    {
        public HomePage(ViewClass v)
        {
            View = v;
            InitializeComponent();
            ShowPersonTable(View.SolicitaListaDePessoas());
        }
        public ViewClass View { get; set; }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //individualsTableLayoutPanel.Size = new Size() { Height = 35, Width = individualsTableLayoutPanel.Width };
            //individualsTableLayoutPanel.ColumnCount = 3;
            //individualsTableLayoutPanel.RowCount = 1;
            //individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            //individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            //individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            //individualsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            //individualsTableLayoutPanel.Controls.Add(new Label() { Text = "Vai" }, 0, 0);
            //individualsTableLayoutPanel.Controls.Add(new Label() { Text = "à" }, 1, 0);

            //ListIcon cadete = new ListIcon(JustiCal.Properties.Resources.cadetIco);
            //cadete.objectPassed = new Person("Hélder Lima", true);

            ////PictureBox pictureBox = new PictureBox();
            ////pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ////pictureBox.ClientSize = new Size(30, 30);
            ////pictureBox.Image = (Image)new Bitmap(JustiCal.Properties.Resources.cadetIco);
            ////individualsTableLayoutPanel.Controls.Add(pictureBox, 2, 0);
            //individualsTableLayoutPanel.Controls.Add(cadete, 2, 0);
            //cadete.Click += Cadete_Click;


            ////individualsTableLayoutPanel.Controls.Add(new Label() { Text = "Merda" }, 2, 0);
            //individualsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        private void Cadete_Click(object sender, EventArgs e)
        {
            if (sender is ListIcon listIcon)
            {
                if (listIcon.objectPassed is Person person)
                    Debug.WriteLine(person.FirstName);
            }
        }

        private void ShowPersonTable(List<object> people)
        {
            Debug.WriteLine("ShowPersonTable");
            individualsTableLayoutPanel.Size = new Size() { Height = 100, Width = individualsTableLayoutPanel.Width };
            individualsTableLayoutPanel.AutoSize = true;
            individualsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            individualsTableLayoutPanel.ColumnCount = 0; individualsTableLayoutPanel.RowCount = 0;
            individualsTableLayoutPanel.ColumnCount = 6;
            individualsTableLayoutPanel.RowCount = 1;

            Debug.WriteLine(String.Format("Columns Styles Count: {0}", individualsTableLayoutPanel.ColumnStyles.Count));
            TableLayoutColumnStyleCollection styles = individualsTableLayoutPanel.ColumnStyles;
            for (int i = styles.Count; i > 0; i--)
            {
                styles.RemoveAt(i-1);
            }
            Debug.WriteLine(String.Format("Columns Styles Count: {0}", individualsTableLayoutPanel.ColumnStyles.Count));


            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));   //Coluna 1 com largura variavel
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));   //Coluna 2 com largura variavel
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));   //Coluna 3 com largura variavel
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));   //Coluna 4 com largura fixa
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));   //Coluna 5 com largura fixa
            individualsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));   //Coluna 6 com largura fixa


            individualsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            individualsTableLayoutPanel.Controls.Add(new TitleLabel("N.º Documento", AnchorStyles.Left), 0, 0);
            individualsTableLayoutPanel.Controls.Add(new TitleLabel("Primeiro Nome", AnchorStyles.Left), 1, 0);
            individualsTableLayoutPanel.Controls.Add(new TitleLabel("Apelido", AnchorStyles.Left), 2, 0);
            individualsTableLayoutPanel.Controls.Add(new TitleLabel("Tipo"), 3, 0);
            individualsTableLayoutPanel.Controls.Add(new TitleLabel("Ver"), 4, 0);
            individualsTableLayoutPanel.Controls.Add(new TitleLabel("Apagar"), 5, 0);

            foreach (object item in people)
            {
                individualsTableLayoutPanel.RowCount = individualsTableLayoutPanel.RowCount + 1;
                individualsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
                if (item is Person person)
                {
                    if (person.IdDocuments.Count > 0)
                        individualsTableLayoutPanel.Controls.Add(new MyLabel(person.GetOneDocument(), AnchorStyles.Left), 0, individualsTableLayoutPanel.RowCount - 1);
                    else
                        individualsTableLayoutPanel.Controls.Add(new MyLabel("Sem Documentos", AnchorStyles.Left), 0, individualsTableLayoutPanel.RowCount - 1);
                    individualsTableLayoutPanel.Controls.Add(new MyLabel(person.FirstName, AnchorStyles.Left), 1, individualsTableLayoutPanel.RowCount - 1);
                    individualsTableLayoutPanel.Controls.Add(new MyLabel(person.LastName, AnchorStyles.Left), 2, individualsTableLayoutPanel.RowCount - 1);
                    if (person is Student)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.ClientSize = new Size(30, 30);
                        pictureBox.Image = (Image)new Bitmap(JustiCal.Properties.Resources.cadetIco);
                        individualsTableLayoutPanel.Controls.Add(pictureBox, 3, individualsTableLayoutPanel.RowCount - 1);
                    }
                    else if (person is Militar)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.ClientSize = new Size(30, 30);
                        pictureBox.Image = (Image)new Bitmap(JustiCal.Properties.Resources.militaryIco1);
                        individualsTableLayoutPanel.Controls.Add(pictureBox, 3, individualsTableLayoutPanel.RowCount - 1);
                    }
                    else
                    {
                        individualsTableLayoutPanel.Controls.Add(new Label() { Text = "   " }, 3, individualsTableLayoutPanel.RowCount - 1);
                    }
                    ListIcon listIconWatch = new ListIcon(JustiCal.Properties.Resources.watchIco);
                    listIconWatch.objectPassed = item;
                    listIconWatch.Click += ListIconWatch_Click;
                    individualsTableLayoutPanel.Controls.Add(listIconWatch, 4, individualsTableLayoutPanel.RowCount - 1);


                    ListIcon listIconDelete = new ListIcon(JustiCal.Properties.Resources.deleteIco);
                    listIconDelete.objectPassed = item;
                    listIconDelete.Click += ListIconDelete_Click;
                    individualsTableLayoutPanel.Controls.Add(listIconDelete, 5, individualsTableLayoutPanel.RowCount - 1);
                }
                if (item is Student)
                {
                }
            }
        }

        private void ListIconDelete_Click(object sender, EventArgs e)
        {
            if (sender is ListIcon icon)
            {
                View.CliqueEmApagarPessoa(icon.objectPassed);
            }
        }

        private void ListIconWatch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void PeopleTabPage_Enter(object sender, EventArgs e)
        {
            //ShowPersonTable(View.SolicitaListaDePessoas());
        }

        private void criarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarPessoaForm adicionarPessoaForm = new AdicionarPessoaForm(View);
            DialogResult result = adicionarPessoaForm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
