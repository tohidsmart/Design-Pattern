using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class ShippingCostCalculation
	{
		public double CalculateShippingCost(Order order)
		{
			switch (order.ShippingMethod)
			{
				case Address.ShippingOption.FedEx:
					return CalculateForFedex(order);
				case Address.ShippingOption.UPS:
					return CalculateForUPS(order);
				case Address.ShippingOption.Pos:
					return CalculateForPos(order);
				default:
					throw new Exception();
			}

		}

		private double CalculateForFedex(Order order)=> 3.00d;


		private double CalculateForPos(Order order)=> 2.00d;
		
		private double CalculateForUPS(Order order0)=> 4.00d;
		

	}
}
