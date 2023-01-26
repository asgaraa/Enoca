using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Firma;
using ServiceLayer.Services.Interfaces;

namespace EnocaApi.Controllers
{

	public class FirmController : BaseController
	{
		private readonly IFirmService _service;
		public FirmController(IFirmService service)
		{
			_service = service;
		}

		[HttpPost]
		[Route("CreateFirm")]
		public async Task<IActionResult> Create([FromBody] FirmaDto firmaDto)
		{
			await _service.CreateAsync(firmaDto);
			return Ok();
		}

		[HttpDelete]
		[Route("DeleteFirm/{id}")]
		public async Task<IActionResult> Delete([FromRoute] string id)
		{
			await _service.DeleteAsync(id);

			return Ok();
		}
		[HttpPut]
		[Route("UpdateFirm")]
		public async Task<IActionResult> Update([FromBody] FirmaEditDto firmaEditDto)
		{


			await _service.UpdateAsync(firmaEditDto.Id, firmaEditDto);
			return Ok();
		}

		[HttpGet]
		[Route("GetById/{id}")]
		public async Task<IActionResult> GetById([FromRoute] string id)
		{
			var result = await _service.GetAsync(id);
			return Ok(result);
		}

		[HttpGet]
		[Route("GetAllFirms")]
		public async Task<IActionResult> GetAll()
		{
			var result = await _service.GetAllAsync();
			return Ok(result);
		}
	}
}
