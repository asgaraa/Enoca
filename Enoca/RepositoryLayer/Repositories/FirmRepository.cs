using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
	public class FirmRepository : Repository<Firm>, IFirmRepository
	{
		public FirmRepository(AppDbContext context) : base(context)
		{
		}


	}
}
