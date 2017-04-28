using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade
{
	class Program
	{
		static void Main(string[] args)
		{
			MailManager mm = new MailManager();
			mm.From("")
				.TO("")
				.Subject("")
				.Send();

			BetterMailManager bmm = new BetterMailManager();
			BetterMailManager.Send(x => x.From("").TO("").Subject(""));
		}
	}
}
