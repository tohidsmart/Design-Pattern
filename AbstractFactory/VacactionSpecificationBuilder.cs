using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class VacactionSpecificationBuilder
	{
		private DateTime arrivalDate;
		private int totalNights;
		private IList<IVacationPart> vacationParts = new List<IVacationPart>();
		private IHotelService hotelService;
		private IAirPlaneService airPlaneService;
		private string livingPlace;
		private string destinationPlace;

		private IVacationPartFactory partFactory;

		public VacactionSpecificationBuilder(IVacationPartFactory partFactory,DateTime arrivalDate,int totalNights,string livingPlace,string destinationPlace)
		{
			this.partFactory = partFactory;
			this.arrivalDate = arrivalDate;
			this.totalNights = totalNights;
			this.livingPlace = livingPlace;
			this.destinationPlace = destinationPlace;

		}



		public VacationSpecifciation CreateVacation()
		{

			foreach (var vacationPart in vacationParts)
			{
				vacationPart.Purchase();

			}

			return new VacationSpecifciation(this.vacationParts);
		}

		public void SelectHotel(string hotelName)
		{
			IVacationPart part = this.partFactory.CreateHotelReservation(this.livingPlace, this.destinationPlace,this.arrivalDate, this.arrivalDate.AddDays(this.totalNights));
			this.vacationParts.Add(part);

		}

		public void SelectFlight(string companyName)
		{
			this.vacationParts.Add(this.partFactory.CreateFlight(companyName, this.livingPlace,this.destinationPlace, this.arrivalDate));
			this.vacationParts.Add(this.partFactory.CreateFlight(companyName, this.destinationPlace, this.livingPlace, this.arrivalDate.AddDays(this.totalNights)));
	
		}
	}
}
