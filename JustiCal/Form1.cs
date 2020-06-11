using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = System.Threading.Tasks.Task;

namespace JustiCal
{
    public partial class Form1 : Form
    {
        private View view;
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(View view)
        {
            InitializeComponent();
            View = view;
        }

        public View View { get; set; }

        public void updateBookmark(string bookmarkToBeUpdated, string newText, Microsoft.Office.Interop.Word.Document document)
        {
            
                //Object name = "militar";
                //Microsoft.Office.Interop.Word.Range range = document.Bookmarks.get_Item(ref name).Range;
                Microsoft.Office.Interop.Word.Bookmark bookmark = document.Bookmarks.get_Item("militar");
                MessageBox.Show(bookmark.Range.Text);

        }

        public void CreateDocument()
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

            //We dont't want animations. We are serious people
            winword.ShowAnimation = false;

            //We don't want the user to see the Word Application
            winword.Visible = false;

            //Let's create out document using the template given
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            //string fullPath = openFileDialog.FileName;
            //MessageBox.Show(fullPath);
            Microsoft.Office.Interop.Word.Document oDocument = winword.Documents.Add(openFileDialog.FileName);
            updateBookmark("militar", "gajo", oDocument);
            //winword.


        }



        private void button1_Click(object sender, EventArgs e)
        {
            Student oStudent = new Student(238, "GNR-Armas", 3, 1, "civil", "Cadete-Aluno", null, "16083006", "Hélder Alexandre de Sousa Lima", true);
            Militar oMilitar = new Militar("Capitão", "Artilharia", "11197709", "Paulo Alberto Ferreira da Silva Freitas", true);
            DateTime data = new DateTime(2007, 5, 1);
            Participacao oParticipacao = new Participacao(data, DateTime.Now, oMilitar);
            ProcessoAA oProcessoAA = new ProcessoAA(oStudent, oParticipacao);
            oProcessoAA.Nr = "PAA055/2020CAL";  //TODO apagar. Só está aqui porque ainda não foi criado método para atribuir número aos processos
            Capa oCapa = new Capa(oProcessoAA);
            oProcessoAA.saveDocument(oProcessoAA, oCapa.CapaDocument, "Capa");
            

            //CreateDocument();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }
    }
}
