using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain
{
	public class ExpenseReport:IExpenceReport
	{
		public decimal Total { get; }
		

		public ExpenseReport(decimal total)
		{
			Total = total;
		}
	}
}
