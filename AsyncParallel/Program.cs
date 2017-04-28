using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncParallel
{
	class Program
	{
		static void Main(string[] args)
		{
			int x=-1, y=1, z=0;
			Task t = Task.Factory.StartNew(() => {
				Console.Write(x);
				Console.Write(y);
				Console.Write(z);
			});


		}
	}
}
