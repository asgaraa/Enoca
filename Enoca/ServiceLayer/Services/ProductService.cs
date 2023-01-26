using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Product;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _repository;
		private readonly IMapper _mapper;
		private readonly IFirmRepository _firmRepository;
		public ProductService(IProductRepository repository,
							  IMapper mapper,
							  IFirmRepository firmRepository)
		{
			_repository = repository;
			_mapper = mapper;
			_firmRepository = firmRepository;
		}

		public async Task CreateAsync(ProductDto productDto)
		{
			var model = _mapper.Map<Product>(productDto);
			Firm firm = await _firmRepository.GetAsync(productDto.FirmId);
			model.Id = Guid.NewGuid().ToString("N");
			model.Firma = firm;
			await _repository.CreateAsync(model);

		}

		public async Task DeleteAsync(string id)
		{
			var setting = await _repository.GetAsync(id);
			await _repository.DeleteAsync(setting);
		}

		public async Task<List<ProductDto>> GetAllAsync()
		{
			var model = await _repository.GetAllAsync();
			var res = _mapper.Map<List<ProductDto>>(model);
			return res;
		}

		public async Task UpdateAsync(string Id, ProductEditDto productEditDto)
		{
			var entity = await _repository.GetAsync(Id);

			if (productEditDto.Name == null)
			{
				productEditDto.Name = entity.Name;
			}
			if (productEditDto.Price == null)
			{
				productEditDto.Price = entity.Price;
			}


			_mapper.Map(productEditDto, entity);

			await _repository.UpdateAsync(entity);
		}
		public async Task<ProductDto> GetAsync(string id)
		{
			var model = await _repository.GetAsync(id);
			var res = _mapper.Map<ProductDto>(model);
			return res;
		}
	}
}
