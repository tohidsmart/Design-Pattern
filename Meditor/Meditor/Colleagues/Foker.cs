using Meditor.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditor.Colleagues
{
	class Foker : Aircraft
	{
		public override int Ceiling
		{
			get
			{
				return _ceiling;
			}
			set
			{
				Ceiling = 35000;
			}
		}

		public Foker(string callSign, IAirTrafficController tower)
			: base(callSign, tower)
		{

		}
	}
}

