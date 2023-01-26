using ServiceLayer.DTOs.Order;

namespace ServiceLayer.Services.Interfaces
{
	public interface IOrderService
	{
		Task<string> CreateAsync(OrderCreateDto orderDto);
		Task<List<OrderDto>> GetAllAsync();
		Task UpdateAsync(string id, OrderEditDto orderEditDto);
		Task<OrderDto> GetAsync(string id);
		Task DeleteAsync(string id);
	}
}
