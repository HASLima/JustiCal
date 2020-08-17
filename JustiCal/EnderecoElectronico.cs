using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace JustiCal
{
    namespace Model
    {
        [Serializable]
        public class EnderecoElectronico
        {
            
            public string Descricao { get; set; }
            public string Address { get; set; }
            public EnderecoElectronico(string descricao, string mailAddress)
            {
                Descricao = descricao;
                Address = mailAddress;
            }

        } 
    }
}
