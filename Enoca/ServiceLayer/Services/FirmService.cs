using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Firma;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
	public class FirmService : IFirmService
	{
		private readonly IFirmRepository _repository;
		private readonly IMapper _mapper;
		public FirmService(IFirmRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task CreateAsync(FirmaDto firmaDto)
		{
			Firm firm = _mapper.Map<Firm>(firmaDto);
			firm.Id = Guid.NewGuid().ToString("N");

			await _repository.CreateAsync(firm);

		}

		public async Task DeleteAsync(string id)
		{
			var setting = await _repository.GetAsync(id);
			await _repository.DeleteAsync(setting);
		}

		public async Task<List<FirmaDto>> GetAllAsync()
		{
			var model = await _repository.GetAllAsync();
			var res = _mapper.Map<List<FirmaDto>>(model);
			return res;
		}

		public async Task UpdateAsync(string Id, FirmaEditDto firmaEditDto)
		{
			var entity = await _repository.GetAsync(Id);


			if (firmaEditDto.OrderAccess == null)
			{
				firmaEditDto.OrderAccess = entity.OrderAccess;
			}
			if (firmaEditDto.OrderEndTime == null)
			{
				firmaEditDto.OrderEndTime = entity.OrderEndTime;
			}
			if (firmaEditDto.OrderStartTime == null)
			{
				firmaEditDto.OrderStartTime = entity.OrderStartTime;
			}


			_mapper.Map(firmaEditDto, entity);

			await _repository.UpdateAsync(entity);
		}
		public async Task<FirmaDto> GetAsync(string id)
		{
			var model = await _repository.GetAsync(id);
			var res = _mapper.Map<FirmaDto>(model);
			return res;
		}
	}
}
