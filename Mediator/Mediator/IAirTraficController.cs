using Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
	public interface IAirTraficController
	{
		void ReciveOtherAirCraftLocation(AirCraft reportingAirCraftLocation);
		void RegisterAirCraftUnderGuidance(AirCraft aircraft);
	}
}
