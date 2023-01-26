using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddServiceLayer(this IServiceCollection services)
		{
			services.AddScoped<IFirmService, FirmService>();
			services.AddScoped<IOrderService, OrderService>();
			services.AddScoped<IProductService, ProductService>();

			services.AddHttpContextAccessor();

			return services;
		}
	}
}
