using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
