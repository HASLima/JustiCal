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
                if(CartaoDeCidadao.CheckDocumentNumber("133683761ZX8"))
                {
                    CartaoDeCidadao oDocumento = new CartaoDeCidadao("133683761ZX8", new DateTime(2021, 10, 10));
                    Console.WriteLine(String.Format("Cartão de Cidadão n.º: {0}\nN.º de Identificação Civil: {1}\nDigito de Controlo do N.º de Identificação Civil: {2}\nVersão: {3}\nN.º de controlo do Cartão de Cidadão: {4}\nData de Validade: {5}", oDocumento.DocumentNumber, oDocumento.CivilianIdNumber, oDocumento.CivilianIdNumberCheckDigit.ToString(), oDocumento.Version, oDocumento.DocumentNumberCheckDigit, oDocumento.ExpiryDate.ToString()));
                }
                    

                

                Console.Read();

                //Este é o código originalmente criado pelo VIsual Studio
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());

            }
        } 
    }
}
