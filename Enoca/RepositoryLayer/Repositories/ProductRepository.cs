using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		public ProductRepository(AppDbContext context) : base(context)
		{
		}
	}
}
