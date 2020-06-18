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
                Model.ContactoTelefonico contacto = new Model.ContactoTelefonico("969239643", "3531581");
                Console.WriteLine(contacto.Pais);

                Model.Person pessoa = new Model.Person("Hélder Alexandre de Sousa Lima", true, null, new DateTime(1988, 3, 2), new Morada("Rua", "Dias Lourenço", "10", null, "2925", "135"),new ContactoTelefonico("969239643"),new System.Net.Mail.MailAddress("haslima@gmail.com"),"Hélder Carvalho Lima", "Maria Armanda Leite da Costa Sousa", null, "Portuguesa");
                Militar militar = new Militar("Capitão", "Infantaria", "2080018", pessoa);

                //militar.Filiacao[0] = "Hélder Carvalho Lima";
                //militar.Filiacao[1] = "Maria Armanda Leite da Costa Sousa";

                Console.WriteLine(String.Format("Filho de {0} e {1}", militar.Filiacao[0], militar.Filiacao[1]));

                Console.Read();

                //Este é o código originalmente criado pelo VIsual Studio
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());

            }
        } 
    }
}
