using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	interface IHotelService
	{
		IVacationPart MakeBooking(string hotelName, DateTime checkIn, DateTime checkOut);
	}
}
