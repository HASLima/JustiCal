using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace JustiCal
{
    class ProcessoAA
    {
        private string nr;
        private DespachoLiminar despachoLiminar;
        private Participacao participacao;
        private Person sinistrado;
        private List<OficialInstrutor> oficiaisInstrutores;
        private Capa capa;

        public ProcessoAA(Person sinistrado, Participacao participacao)
        {
            //TODO definir a forma de actribuir nr
            Participacao = participacao;
            this.sinistrado = sinistrado;
        }
        public ProcessoAA(string nrProcesso, Person sinistrado, Participacao participacao)
        {
            Nr = nrProcesso;
            Participacao = participacao;
            this.sinistrado = sinistrado;
        }

        public string Nr
        {
            get { return nr; }
            set { nr = value; }
        }

        public DespachoLiminar DespachoLiminar
        {
            get { return despachoLiminar; }
            set { despachoLiminar = value; }
        }

        public Participacao Participacao
        {
            get { return participacao; }
            set { participacao = value; }
        }

        public Person Sinistrado
        {
            get { return sinistrado; }
            set { sinistrado = value; }
        }

        public List<OficialInstrutor> OficiaisInstrutores
        {
            get { return oficiaisInstrutores; }
        }

        public Capa Capa
        {
            get { return capa; }
            set { capa = value; }
        }

        public void AddOficialInstrutor(Militar oficialInstrutor, DateTime inicialDate, DateTime? finalDate = null)
        {
            //TODO impementar
        }

        public Microsoft.Office.Interop.Word.Application CreateWinWord()
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
            winword.ShowAnimation = false;
            winword.Visible = false;
            return winword;
        }

        public void UpdateBookMark(Bookmark bookmark, string newText, Microsoft.Office.Interop.Word.Document document)
        {
            object range = bookmark.Range;
            string bookmarkName = bookmark.Name;

            bookmark.Range.Text = newText;

            document.Bookmarks.Add(bookmarkName, ref range);
        }

        public void saveDocument(ProcessoAA processo, Microsoft.Office.Interop.Word.Document documento, string sufixo = null)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.FileName = processo.Nr.Replace('/', '_');
            if (sufixo != null)
                saveFileDialog.FileName += " " + sufixo;
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog.ValidateNames = true;
            saveFileDialog.ShowDialog();
            documento.SaveAs2(saveFileDialog.FileName, 17, false, AddToRecentFiles: true, WritePassword: "HASLima", ReadOnlyRecommended: true);
        }

        public void PrintCapa()
        {
            if (Nr != null)
            {
                Microsoft.Office.Interop.Word.Document capaDocument;
                Microsoft.Office.Interop.Word.Application winword = CreateWinWord();
                winword.Visible = false;
                capaDocument = winword.Documents.Add("C:\\Users\\hasli\\Documents\\CapaPAA.dotx");
                UpdateBookMark(capaDocument.Bookmarks.get_Item("nrProcesso"), Nr, capaDocument);
                UpdateBookMark(capaDocument.Bookmarks.get_Item("nome"), Sinistrado.getFullName().ToUpper(), capaDocument);
                if (!Sinistrado.Masculino)
                    UpdateBookMark(capaDocument.Bookmarks.get_Item("eleOuEla"), "Sinistrada".ToUpper(), capaDocument);
                if (Sinistrado is Militar)
                {
                    Militar militarSinistrado = Sinistrado as Militar;
                    UpdateBookMark(capaDocument.Bookmarks.get_Item("posto"), militarSinistrado.Posto, capaDocument);
                    if (militarSinistrado.Arma == null)
                        UpdateBookMark(capaDocument.Bookmarks.get_Item("arma"), "---", capaDocument);
                    else
                        UpdateBookMark(capaDocument.Bookmarks.get_Item("arma"), militarSinistrado.Arma, capaDocument);
                    if (militarSinistrado.Nr == null)
                        UpdateBookMark(capaDocument.Bookmarks.get_Item("nr"), "---", capaDocument);
                    else
                        UpdateBookMark(capaDocument.Bookmarks.get_Item("nr"), militarSinistrado.Nr, capaDocument);
                    if (Sinistrado is Student)
                    {
                        Student studentSinistrado = Sinistrado as Student;
                        UpdateBookMark(capaDocument.Bookmarks.get_Item("nrCorpo"), studentSinistrado.NrCorpo.ToString(), capaDocument);
                    }
                    else
                        UpdateBookMark(capaDocument.Bookmarks.get_Item("nrCorpo"), "---", capaDocument);
                }
                else
                {
                    UpdateBookMark(capaDocument.Bookmarks.get_Item("posto"), "---", capaDocument);
                    UpdateBookMark(capaDocument.Bookmarks.get_Item("arma"), "---", capaDocument);
                    UpdateBookMark(capaDocument.Bookmarks.get_Item("nrCorpo"), "---", capaDocument);
                    UpdateBookMark(capaDocument.Bookmarks.get_Item("nr"), "---", capaDocument);
                }
            }
        }
    }

    class Document
    {
        private DateTime date;
        private Person signatory;

        public Document(DateTime date, Person signatory)
        {
            Date = date;
            Signatory = signatory;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Person Signatory
        {
            get { return signatory; }
            set { signatory = value; }
        }
    }

    class DespachoLiminar : Document
    {
        private Militar instrutorNomeado;

        public DespachoLiminar (DateTime date, Militar instrutorNomeado, Militar signatory): base (date, signatory)
        {
            InstrutorNomeado = instrutorNomeado;
        }

        public Militar InstrutorNomeado
        {
            get { return instrutorNomeado; }
            set { instrutorNomeado = value; }
        }
    }

    class Participacao : Document
    {
        private DateTime relevantDate;
        public Participacao(DateTime relevantDate, DateTime date, Militar signatory): base (date, signatory)
        {
            RelevantDate = relevantDate;
        }
        public DateTime RelevantDate
        {
            get { return relevantDate; }
            set { relevantDate = value; }
        }
    }

    class Capa //can't be a Document inherited class because Capa doesn't have a signatory
    {
        private Microsoft.Office.Interop.Word.Document capaDocument;
        public Capa(ProcessoAA processo)
        {
            Microsoft.Office.Interop.Word.Application winword = processo.CreateWinWord();
            winword.Visible = false;
            capaDocument = winword.Documents.Add("C:\\Users\\hasli\\Documents\\CapaPAA.dotx");
            processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("nrProcesso"), processo.Nr, capaDocument);
            processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("nome"), processo.Sinistrado.getFullName().ToUpper(), capaDocument);
            if (!processo.Sinistrado.Masculino)
                processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("eleOuEla"), "Sinistrada".ToUpper(), capaDocument);
            if (processo.Sinistrado is Militar)
            {
                Militar militarSinistrado = processo.Sinistrado as Militar;
                processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("posto"), militarSinistrado.Posto, capaDocument);
                if (militarSinistrado.Arma == null)
                    processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("arma"), "---", capaDocument);
                else
                    processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("arma"), militarSinistrado.Arma, capaDocument);
                if (militarSinistrado.Nr == null)
                    processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("nr"), "---", capaDocument);
                else
                    processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("nr"), militarSinistrado.Nr, capaDocument);
                if (processo.Sinistrado is Student)
                {
                    Student studentSinistrado = processo.Sinistrado as Student;
                    processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("nrCorpo"), studentSinistrado.NrCorpo.ToString(), capaDocument);
                }
                else
                    processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("nrCorpo"), "---", capaDocument);
            }
            else
            {
                processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("posto"), "---", capaDocument);
                processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("arma"), "---", capaDocument);
                processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("nrCorpo"), "---", capaDocument);
                processo.UpdateBookMark(capaDocument.Bookmarks.get_Item("nr"), "---", capaDocument);
            }
        }
        public Microsoft.Office.Interop.Word.Document CapaDocument
        {
            get { return capaDocument; }
        }


        //TODO think about implementing a deconstructor.
    }


}
