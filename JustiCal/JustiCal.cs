using JustiCal.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Services;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace JustiCal
{
    namespace Controller
    {


        static class JustiCal
        {
            /// <summary>
            /// Ponto de entrada principal para o aplicativo.
            /// </summary>
            /// 
            static Controller controller;
            [STAThread]



            static void Main()
            {
                controller = new Controller();
                controller.View.ActivarUI();

                Person oPerson2 = new Person("Andreia Sofia Saraiva dos Santos Lima", false, null, new DateTime(1987, 9, 13), new Morada("Rua", "Dias Lourenço", "10", null, "2925", "135"), new ContactoTelefonico("969654740"), new System.Net.Mail.MailAddress("assantos.lima@gmail.com"), "José Carlos Santos", "Ana Paula Saraiva dos Santos", null, null);
                CartaoDeCidadao cartaoDeCidadao = new CartaoDeCidadao("133683761ZX8", new DateTime(2021, 10, 01));
                oPerson2.IdDocuments.Add(cartaoDeCidadao);
                Person oPessoa = new Person("Hélder Alexandre de Sousa Lima", true, new List<IdDocument>{ new CartaoDeCidadao("133683761ZX8", 10, 10, 2021) }, new DateTime(1988, 3, 2), new Morada("Rua", "António Alves", "44", null, "4700", "253"), new ContactoTelefonico("969239643"), new System.Net.Mail.MailAddress("haslima@gmail.com"), "Hélder Carvalho Lima", "Maria Armanda Leite da Costa Sousa");

                //test area
                BilheteDeIdentidade oBilhete = new BilheteDeIdentidade("13368376", 1, 2, 3, 2000, 2, 3, 2005, "Braga");
                //BilheteDeIdentidade oBilhete = new BilheteDeIdentidade("13368376", 1, new DateTime(2000, 3, 2), new DateTime(2005, 03, 02), "Braga");
                Console.WriteLine(String.Format("Bilhete de identidade n.º {0}\nEmitido a {1} em {3}\nVálido até {2}", oBilhete.DocumentNumber, oBilhete.IssueDate.Value.Date.ToString(), oBilhete.ExpiryDate.Value.ToString(), oBilhete.IssuePlace));

                    

                

                Console.Read();

                //Este é o código originalmente criado pelo VIsual Studio
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());

            }
        } 
    }
}
