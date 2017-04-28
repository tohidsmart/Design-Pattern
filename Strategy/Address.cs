using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	 public class Address
	{
		public string ContactName { get; set; }
		public string AddressLine { get; set; }
		public string AddressLine2 { get; set; }
		public string AddressLine3 { get; set; }
		public string City { get; set; }
		public	string Region { get; set; }
		public string Country { get; set; }
		public string PostalCode { get; set; }

		public enum ShippingOption
		{
			UPS=100,
			FedEx=200,
			Pos=300
		}

	}
}
