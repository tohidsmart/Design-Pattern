using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade
{
	public class MailManager
	{
		public MailManager Subject(string Subject)
		{
			Console.WriteLine("subject is :{0}", Subject);
			return this;
		}

		public MailManager TO(string receiverAddress)
		{
			Console.WriteLine("Receiver is :{0}", receiverAddress);
			return this;
		}
		public MailManager From(string sender)
		{
			Console.WriteLine("Sender is :{0}", sender);
			return this;
		}

		public MailManager Send()
		{
			Console.WriteLine("Sent");
			return this;

		}

	}

	public class BetterMailManager
	{
		public BetterMailManager Subject(string Subject)
		{
			Console.WriteLine("subject is :{0}", Subject);
			return this;
		}

		public BetterMailManager TO(string receiverAddress)
		{
			Console.WriteLine("Receiver is :{0}", receiverAddress);
			return this;
		}
		public BetterMailManager From(string sender)
		{
			Console.WriteLine("Sender is :{0}", sender);
			return this;
		}

		public static void Send(Action<BetterMailManager> mmObject)
		{
			mmObject(new BetterMailManager());
			
		}
	}
}
