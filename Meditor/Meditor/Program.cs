using Meditor.Colleagues;
using Meditor.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditor
{
	class Program
	{
		static void Main(string[] args)
		{
			IAirTrafficController tower = new ConcreteTower();

			Aircraft Boeing = new Boeing("Boeing777", tower);
			Aircraft AirBus = new AirBus("AirBus380", tower);
			Aircraft Foker = new Foker("Foker", tower);

			Boeing.Altitude = 34000;
			AirBus.Altitude = 34500;
			Foker.Altitude = 40000;


		}
	}
}
