using Meditor.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditor.Colleagues
{
	class AirBus:Aircraft
	{
		public override int Ceiling
		{
			get
			{
				return _ceiling;
			}
			set
			{
				Altitude = 38000;
			}
		}

		public AirBus(string callSign,IAirTrafficController tower):base(callSign,tower)
		{

		}
	}
}
