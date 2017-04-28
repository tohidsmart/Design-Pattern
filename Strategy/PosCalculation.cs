using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class PosCalculation:IShippingStrategy
	{
		public double CalculateShippingCost(Order order)=>3.00d;
		
	}
}
