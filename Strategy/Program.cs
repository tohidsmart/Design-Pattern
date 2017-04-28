using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			Order order=new Order(){ShippingMethod=Address.ShippingOption.FedEx};
			ShippingCostCalculation Sc = new ShippingCostCalculation();
			Console.WriteLine(Sc.CalculateShippingCost(order));

			Order order2 = new Order();
			IShippingStrategy strategy = new UPSCalculation();
			ShippingCalculation_WithStrategy sc_wihStrateg = new ShippingCalculation_WithStrategy(strategy);
			Console.WriteLine(sc_wihStrateg.CalculateShippingCost(order2));
		}
	}
}
