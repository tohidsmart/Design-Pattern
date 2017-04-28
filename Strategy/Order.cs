using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class Order
	{
		public Address.ShippingOption  ShippingMethod { get; set; }
		public Address Destination { get; set; }
		public Address Origin { get; set; }
	}
}
