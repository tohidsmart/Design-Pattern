using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleague
{
	class Foker : AirCraft
	{
		public Foker(string callSign, IAirTraficController tower)
			: base(callSign, tower)
		{

		}
		protected override int Ceiling
		{
			get
			{
				return _ceiling;
			}
			set
			{
				_ceiling = 35000;
			}
		}
	}
}
