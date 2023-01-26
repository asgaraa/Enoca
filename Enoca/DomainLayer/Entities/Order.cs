using DomainLayer.Common;

namespace DomainLayer.Entities
{
	public class Order : BaseEntity
	{
		public Firm Firm { get; set; }
		public Product Product { get; set; }
		public string Name { get; set; }
		public DateTime OrderDate { get; set; } = DateTime.UtcNow;
	}
}
