using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class ShippingCalculation_WithStrategy
	{
		private readonly IShippingStrategy shippingStrategy;

		public ShippingCalculation_WithStrategy(IShippingStrategy shippingStrategy)
		{
			this.shippingStrategy = shippingStrategy;
		}

		public double CalculateShippingCost(Order order)=>shippingStrategy.CalculateShippingCost(order);
		
	}
}
