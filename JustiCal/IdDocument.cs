using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace JustiCal
{
    namespace Model
    {
        public class IdDocument
        {
            public enum DocumentType
            {
                CartaoDeCidadao = 0,
                BilheteDeIdentidade = 1,
                BilheteDeIdentidadeMilitar = 2,
                Passaporte = 3,
                TituloDeResidencia = 4,
                AutorizacaoDeResidencia
            }

            public string DocumentNumber { get; set; }
            public DateTime? ExpiryDate { get; set; }
            public DateTime? IssueDate { get; set; }

            public IdDocument()
            {

            }

        }

        class CartaoDeCidadao : IdDocument
        {
            public CartaoDeCidadao()
            {
                
            }

            public string civilianIdNumber { get; set; }
            public string controlDigits1 { get; set; }
        }
    }
}