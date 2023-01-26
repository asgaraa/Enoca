using ServiceLayer.DTOs.Firma;
using ServiceLayer.DTOs.Product;

namespace ServiceLayer.DTOs.Order
{
	public class OrderDto
	{
		public FirmaDto Firm { get; set; }
		public ProductDto Product { get; set; }
		public string Name { get; set; }
		public DateTime OrderDate { get; set; } = DateTime.UtcNow;
	}
}
