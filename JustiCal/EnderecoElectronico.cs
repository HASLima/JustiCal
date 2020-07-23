using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace JustiCal
{
    public class EnderecoElectronico : MailAddress
    {
        public string Descricao { get; set; }
        public EnderecoElectronico(string descricao, string mailAddress) :base(mailAddress)
        {
            Descricao = descricao;
        }

    }
}
