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
            //static Controller controller;
            [STAThread]
            static void Main()
            {
                Controller controller = new Controller();
                controller.View.ActivarUI();
                   
                Console.Read();

                //Este é o código originalmente criado pelo VIsual Studio
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());

            }
        } 
    }
}
//TODO: in the about page set a link to the icons page https://support.flaticon.com/hc/en-us/articles/207248209-How-I-must-insert-the-attribution-
// cadetIco.png "Icon made by FreePik from www.flaticon.com" (https://www.flaticon.com/authors/freepik)
// militaryIco.png "Icon made by Eucalyp from www.flaticon.com" (https://www.flaticon.com/authors/eucalyp")
// findCPIco.png "Icon made by FreePik from www.flaticon.com" (https://www.flaticon.com/authors/freepik)
// addPersonIco.png "Icon made by Smashicons from www.flaticon.com" (https://www.flaticon.com/authors/smashicons)
// removePersonIco.png "Icon made by Smashicons from www.flaticon.com" (https://www.flaticon.com/authors/smashicons)
// editPersonIco.png "Icon made by Smashicons from www.flaticon.com" (https://www.flaticon.com/authors/smashicons)
// searchPersonIco.png "Icon made by Smashicons from www.flaticon.com" (https://www.flaticon.com/authors/smashicons)
// addProcessIco.png "Icon made by <a href="http://www.dariusdan.com/" title="Darius Dan">Darius Dan</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
// editProcessIco.png "Icon made by <a href="http://www.dariusdan.com/" title="Darius Dan">Darius Dan</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
// searchProcessIco.png "Icon made by <a href="http://www.dariusdan.com/" title="Darius Dan">Darius Dan</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
// removeProcessIco.png "Icon made by <a href="http://www.dariusdan.com/" title="Darius Dan">Darius Dan</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>