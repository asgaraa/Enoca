using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Order;
using ServiceLayer.DTOs.Product;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(OrderDto orderDto)
        {
            var model = _mapper.Map<Order>(orderDto);
            await _repository.CreateAsync(model);

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
