using DomainLayer.Common;

namespace DomainLayer.Entities
{
	public class Product : BaseEntity
	{
		public Firm Firma { get; set; }
		public string Name { get; set; }
		public int Stok { get; set; }
		public double Price { get; set; }
	}
}
