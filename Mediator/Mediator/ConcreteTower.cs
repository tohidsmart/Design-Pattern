using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Colleague;

namespace Mediator.Mediator
{
	class ConcreteTower : IAirTraficController
	{
		List<AirCraft> allAirCraftsUnderGuidance = new List<AirCraft>();

		public void RegisterAirCraftUnderGuidance(AirCraft aircraft)
		{
			if (!allAirCraftsUnderGuidance.Contains(aircraft)) allAirCraftsUnderGuidance.Add(aircraft);
		}

		public void ReciveOtherAirCraftLocation(AirCraft reportingAirCraftLocation)
		{
			foreach (var airCraft in allAirCraftsUnderGuidance.Where(x => x.CallSign != reportingAirCraftLocation.CallSign))
			{
				if (Math.Abs(airCraft.Altitude - reportingAirCraftLocation.Altitude) < 1000)
				{
					airCraft.WarnIntrusionAirSpaceBy(reportingAirCraftLocation);
				}
			}
		}
	}
}
