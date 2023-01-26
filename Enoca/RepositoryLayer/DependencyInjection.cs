using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
		{
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

			services.AddScoped<IFirmRepository, FirmRepository>();
			services.AddScoped<IOrderRepository, OrderRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();

			return services;
		}
	}
}
