using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleague
{
	public abstract class AirCraft
	{
		
		public string CallSign { get; }
		

		private int _altitude;

		public int Altitude
		{
			set
			{
				_altitude = value;
				tower.ReciveOtherAirCraftLocation(this);
			}
			get
			{
				return _altitude;
			}

		}

		public void Climb(int altitude)
		{
			Altitude += altitude;
		}

		protected int _ceiling;
		protected virtual int Ceiling
		{
			get
			{
				return _ceiling;
			}
			set
			{
				_ceiling = value;
			}
		}

		private readonly IAirTraficController tower;

		public AirCraft(string callSign, IAirTraficController tower)
		{
			CallSign = callSign;
			tower.RegisterAirCraftUnderGuidance(this);
		}

		public override bool Equals(object obj)
		{
			if (obj.GetType()!=this.GetType()) return false;
			var incoming = (AirCraft)obj;
			return this.CallSign.Equals(incoming.CallSign);
		}

		public override int GetHashCode()=> CallSign.GetHashCode();
		

		public void WarnIntrusionAirSpaceBy(AirCraft reportingAirCraft)
		{
			Console.WriteLine(String.Format("{0} , {1} is getting close to your Altitude,Be alert!!!!", CallSign, reportingAirCraft.CallSign));
		}

	}
}
