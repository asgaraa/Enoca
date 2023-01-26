using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Order;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
	public class OrderService : IOrderService
	{
		private readonly IOrderRepository _repository;
		private readonly IMapper _mapper;
		private readonly IFirmRepository _firmRepository;
		private readonly IProductRepository _productRepository;
		public OrderService(IOrderRepository repository,
							IMapper mapper,
							IFirmRepository firmRepository,
							IProductRepository productRepository)
		{
			_repository = repository;
			_mapper = mapper;
			_firmRepository = firmRepository;
			_productRepository = productRepository;
		}

		public async Task<string> CreateAsync(OrderCreateDto orderDto)
		{
			Firm firm = await _firmRepository.GetAsync(orderDto.FirmId);
			if (!firm.OrderAccess)
			{
				return "Firma Onaylı Değil";
			}

			if ((firm.OrderStartTime! <= DateTime.Now) || (firm.OrderEndTime! >= DateTime.Now))
			{
                //($"{DateTime.UtcNow.ToString("HH:mm")}")

                return "Firma şuan sipariş almıyor";
			}
			Product product = await _productRepository.GetAsync(orderDto.ProductId);
			Order newOrder = _mapper.Map<Order>(orderDto);
			newOrder.Id = Guid.NewGuid().ToString("N");
			newOrder.Firm = firm;
			newOrder.Product = product;

			await _repository.CreateAsync(newOrder);

			return ($"{DateTime.UtcNow.ToString("HH:mm")}");
		}

		public async Task DeleteAsync(string id)
		{
			var setting = await _repository.GetAsync(id);
			await _repository.DeleteAsync(setting);
		}

		public async Task<List<OrderDto>> GetAllAsync()
		{
			var model = await _repository.GetAllAsync();
			var res = _mapper.Map<List<OrderDto>>(model);
			return res;
		}

		public async Task UpdateAsync(string Id, OrderEditDto orderEditDto)
		{
			var entity = await _repository.GetAsync(Id);

			if (orderEditDto.Name == null)
			{
				orderEditDto.Name = entity.Name;
			}
			if (orderEditDto.OrderDate == null)
			{
				orderEditDto.OrderDate = entity.OrderDate;
			}


			_mapper.Map(orderEditDto, entity);

			await _repository.UpdateAsync(entity);
		}
		public async Task<OrderDto> GetAsync(string id)
		{
			var model = await _repository.GetAsync(id);
			var res = _mapper.Map<OrderDto>(model);
			return res;
		}
	}
}
