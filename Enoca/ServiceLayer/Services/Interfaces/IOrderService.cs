using ServiceLayer.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(OrderDto orderDto);
        Task<List<OrderDto>> GetAllAsync();
        Task UpdateAsync(string id, OrderEditDto orderEditDto);
        Task<OrderDto> GetAsync(string id);
        Task DeleteAsync(string id);
    }
}
