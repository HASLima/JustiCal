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

                //test area
                BilheteDeIdentidade oBilhete = new BilheteDeIdentidade("13368376", 1, 2, 3, 2000, 2, 3, 2005, "Braga");
                //BilheteDeIdentidade oBilhete = new BilheteDeIdentidade("13368376", 1, new DateTime(2000, 3, 2), new DateTime(2005, 03, 02), "Braga");
                Console.WriteLine(String.Format("Bilhete de identidade n.º {0}\nEmitido a {1} em {3}\nVálido até {2}", oBilhete.DocumentNumber, oBilhete.IssueDate.Value.Date.ToString(), oBilhete.ExpiryDate.Value.Date.ToString(), oBilhete.IssuePlace));

                    

                

                Console.Read();

                //Este é o código originalmente criado pelo VIsual Studio
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());

            }
        } 
    }
}
