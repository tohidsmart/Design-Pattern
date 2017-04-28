using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExtra
{
	[Comment("Extended delegae","Tohid")]
	class ExtendedDelegate
	{
		delegate void Notifier(string message);

		Notifier notifier1;

		public void PrintMessage()
		{
			//notifier1 = new Notifier(GoodMorningDelegateMethod);
			//notifier1("John");
			notifier1 += GoodAfternoonDelegateMethod;
			notifier1("John's Wife");
		}

		public void GoodMorningDelegateMethod(string message)
		{
			Console.WriteLine("Good Morning {0}",message);
		}

		public void GoodAfternoonDelegateMethod(string message)
		{
			Console.WriteLine("Good Afternoon {0}", message);
		}
	}
}
