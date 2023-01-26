using DomainLayer.Common;

namespace DomainLayer.Entities
{
	public class Firm : BaseEntity
	{
		public string Name { get; set; }
		public bool OrderAccess { get; set; }
		public DateTime OrderStartTime { get; set; }
		public DateTime OrderEndTime { get; set; }
		public List<Product> Products { get; set; }
	}
}
