using System;

namespace WorkshopService.Models
{
	public class CustomerModel
	{
		public Guid CustomerID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string ContactNumber { get; set; }
		public DateTime DateAdded { get; set; }
		public DateTime? DateUpdated { get; set; }
	}
}
