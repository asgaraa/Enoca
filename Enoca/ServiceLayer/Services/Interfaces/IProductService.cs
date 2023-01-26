using ServiceLayer.DTOs.Product;

namespace ServiceLayer.Services.Interfaces
{
	public interface IProductService
	{
		Task CreateAsync(ProductDto productDto);
		Task<List<ProductDto>> GetAllAsync();
		Task UpdateAsync(string id, ProductEditDto productEditDto);
		Task<ProductDto> GetAsync(string id);
		Task DeleteAsync(string id);
	}
}
