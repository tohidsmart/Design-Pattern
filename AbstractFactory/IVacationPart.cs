using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	interface IVacationPart
	{
		void Purchase();
		void Reserve();
		void Cancel();
	}
}
