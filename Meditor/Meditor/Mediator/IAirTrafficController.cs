using Meditor.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditor.Mediator
{
	public interface IAirTrafficController
	{
		void RegisterAirCraftUnderGuidance(Aircraft plane);
		void ReportCurrentAirCrafAltitude(Aircraft reportingPlane);
	}
}
