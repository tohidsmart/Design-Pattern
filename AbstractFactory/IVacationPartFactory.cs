using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	interface IVacationPartFactory
	{
		IVacationPart CreateHotelReservation(string town, string hotelName, DateTime arrivalDate, DateTime leaveTime);
		IVacationPart CreateFlight(string companyName, string source, string destinationl, DateTime date);
		IVacationPart CreateFerryBooking(string lineName, bool fromMainLand, DateTime date);
		IVacationPart CreateDailyTrip(string tripName, DateTime time);
		IVacationPart CreateMassage(string salon, DateTime date);
	}
}
