using Meditor.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditor.Colleagues
{
	public abstract class Aircraft
	{
		private string _callSign;

		public string CallSign
		{
			get { return _callSign; }
		
		}

		protected int _ceiling;

		public abstract int Ceiling { get; set; }
		

		public void Climb(int altitude)
		{
			Altitude += altitude;
		}
		

		private int _altitude;

		public int Altitude
		{
			get
			{
				return _altitude;
			}
			set {
				_altitude = value;
				tower.ReportCurrentAirCrafAltitude(this);
			}
		}

		private IAirTrafficController tower;

		public Aircraft(string callSign,IAirTrafficController tower)
		{
			_callSign = callSign;
			this.tower = tower;
			tower.RegisterAirCraftUnderGuidance(this);
		}


		public override bool Equals(object obj)
		{
			if (this.GetType() != obj.GetType()) return false ;
			var incoming = (Aircraft)obj;
			return this.CallSign != incoming.CallSign;
		}

		public override int GetHashCode()
		{
			return CallSign.GetHashCode();
		}

		public void WarnIntrusionSpaceBy(Aircraft reprtingAirPlane)
		{
			Console.WriteLine("Be Alert Airplane{2},Airplane {0}, is getting close to you in altitude {1} ...  !!!!",reprtingAirPlane.CallSign,reprtingAirPlane.Altitude,CallSign);
		}
		
		
	}
}
