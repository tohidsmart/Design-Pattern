using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class UPSCalculation:IShippingStrategy
	{
		public double CalculateShippingCost(Order order)=> 5.00d;
		
	}
}
