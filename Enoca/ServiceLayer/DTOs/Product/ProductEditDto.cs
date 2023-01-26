using ServiceLayer.DTOs.Firma;

namespace ServiceLayer.DTOs.Product
{
	public class ProductEditDto
	{
		public string Id { get; set; }
		public FirmaDto Firma { get; set; }
		public string Name { get; set; }
		public bool Stok { get; set; }
		public double Price { get; set; }
	}
}
