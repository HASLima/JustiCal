using System;
using System.Collections.Generic;
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
                Model.ContactoTelefonico contacto = new Model.ContactoTelefonico("969239643", "351");
                Console.WriteLine(contacto.Pais);

                //Este é o código originalmente criado pelo VIsual Studio
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());

            }
        } 
    }
}
