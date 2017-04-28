using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleague
{
	class Boeing : AirCraft
	{
		public Boeing(string callSign, IAirTraficController tower)
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
				_ceiling = 38000;
			}
		}
	}
}
