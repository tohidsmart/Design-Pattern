using Meditor.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditor.Mediator
{
	public class ConcreteTower:IAirTrafficController
	{
		List<Aircraft> airCraftUnderGuidance = new List<Aircraft>();

		public void RegisterAirCraftUnderGuidance(Colleagues.Aircraft plane)
		{
			if (!airCraftUnderGuidance.Contains(plane)) airCraftUnderGuidance.Add(plane);
		}

		public void ReportCurrentAirCrafAltitude(Colleagues.Aircraft reportingPlane)
		{
			foreach (var airCraft in airCraftUnderGuidance.Where(x=>x.CallSign!=reportingPlane.CallSign))
			{
				if (Math.Abs(airCraft.Altitude - reportingPlane.Altitude) < 1000)
				{
					airCraft.WarnIntrusionSpaceBy(reportingPlane);
					reportingPlane.Climb(2000);
				}
			}
		}
	}
}
