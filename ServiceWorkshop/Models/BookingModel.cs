using System;
using WorkshopService.Models;

namespace ServiceWorkshop.Models
{
	public class BookingModel
	{
		public Guid BookingId { get; set; }

		public Guid CustomerID { get; set; }

		public Guid VehicleID { get; set; }

		public DateTime BookingDate { get; set; }

		public string Notes { get; set; }

		public string CustomerName { get; set; }

		public string CustomerContactNumber { get; set; }

		public string VehicleMake { get; set; }

		public string VehicleModel { get; set; }

		public string RegistrationNo { get; set; }

		public CustomerModel Customer { get; set; }

		public VehicleModel Vehicle { get; set; }
	}
}
