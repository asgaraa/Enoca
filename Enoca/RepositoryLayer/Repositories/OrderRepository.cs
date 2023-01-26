using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
	public class OrderRepository : Repository<Order>, IOrderRepository
	{
		public OrderRepository(AppDbContext context) : base(context)
		{
		}
	}
}
