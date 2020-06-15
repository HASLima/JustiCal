using System.Data.Services;
using System.Net;

namespace JustiCal
{
	namespace Model
	{
		public class ContactoTelefonico : IRequestHandler
		{
			public string url;

			public string Numero { get; set; }
			public string Indicativo { get; set; }

			public ContactoTelefonico(string numero, string indicativo = "351")
			{
				Numero = numero;
				Indicativo = indicativo;
			}

			public string CountryByCode(string url)
			{
				var request = (HttpWebRequest)WebRequest.Create(url);

				request.Method = "GET";
				request.UserAgent = RequestConstants.UserAgentValue;
			}
		}
	}
}