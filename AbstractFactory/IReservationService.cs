using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	interface IAirPlaneService
	{
		IVacationPart SelectFlight(string comapnyName, string origin, string destination, DateTime travelDate);
	}
}
