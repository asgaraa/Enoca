using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Firm> Firms { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
