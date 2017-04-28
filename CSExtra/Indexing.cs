using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExtra
{
	class Indexing
	{
		private static List<string> WeekDays =new List<string> { "Mon", "Tue","Wed", "Thur","Fri","Sat","Sun" };

		public string this[int weekday]=>WeekDays.FirstOrDefault();
  

	}

	class Program
	{
		static void Main(string[] args)
		{
			ExtendedDelegate exDelegate = new ExtendedDelegate();
			exDelegate.PrintMessage();
		}
	}
}
