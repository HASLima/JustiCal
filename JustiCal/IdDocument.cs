using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace JustiCal
{
    namespace Model
    {
        public class IdDocument
        {
            public IdDocument(byte documentType, string idNumber, DateTime? expiryDate = null)
            {
                DocumentType = documentType;
                IdNumber = idNumber;
                ExpiryDate = expiryDate;
            }

            public string IdNumber
            {
                get { return idNumber; }
                set { idNumber = value; }
            }
            private string idNumber;

            public byte DocumentType
            {
                get { return documentType; }
                set { documentType = value; }
            }
            private byte documentType;

            public DateTime? ExpiryDate
            {
                get { return expiryDate; }
                set { expiryDate = value; }
            }
            private DateTime? expiryDate;

        } 
    }
}