using Mediator.Colleague;
using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	class Program
	{
		static void Main(string[] args)
		{
			IAirTraficController tower = new ConcreteTower();
			AirCraft Boeing = new Boeing("Boeing747", tower);
			AirCraft Foker = new Foker("Foker323", tower);
			AirCraft AirBus = new AirBus("A380", tower);

			Boeing.Altitude = 34000;
			Foker.Altitude = 34500;



		}
	}
}
