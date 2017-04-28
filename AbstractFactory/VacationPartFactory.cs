using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	public class VacationPartFactory:IVacationPartFactory
	{
		IHotelService hotelService;
		IAirPlaneService airPlaneService;
		
		public VacationPartFactory(IHotelService hotelService,IAirPlaneService airPlaneService)
		{
			this.hotelService = hotelService;
			this.airPlaneService = airPlaneService;
		}

		public IVacationPart CreateHotelReservation(string town, string hotelName, DateTime arrivalDate, DateTime leaveTime)
		{
			IVacationPart part = hotelService.MakeBooking(hotelName,arrivalDate, leaveTime);
			return part;
		}

		public IVacationPart CreateFlight(string companyName, string source, string destination, DateTime date)
		{
			IVacationPart part = airPlaneService.SelectFlight(companyName,source, destination, date);
			return part;
		}

		public IVacationPart CreateFerryBooking(string lineName, bool fromMainLand, DateTime date)
		{
			throw new NotImplementedException();
		}

		public IVacationPart CreateDailyTrip(string tripName, DateTime time)
		{
			throw new NotImplementedException();
		}

		public IVacationPart CreateMassage(string salon, DateTime date)
		{
			throw new NotImplementedException();
		}
	}
}
