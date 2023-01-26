using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Product;
using ServiceLayer.Services.Interfaces;

namespace EnocaApi.Controllers
{

	public class ProductController : BaseController
	{
		private readonly IProductService _service;
		public ProductController(IProductService service)
		{
			_service = service;
		}

		[HttpPost]
		[Route("CreateProduct")]
		public async Task<IActionResult> Create([FromBody] ProductDto productDto)
		{
			await _service.CreateAsync(productDto);
			return Ok();
		}

		[HttpDelete]
		[Route("DeleteProduct/{id}")]
		public async Task<IActionResult> Delete([FromRoute] string id)
		{
			await _service.DeleteAsync(id);

			return Ok();
		}
		[HttpPut]
		[Route("UpdateProduct")]
		public async Task<IActionResult> Update([FromBody] ProductEditDto productEditDto)
		{


			await _service.UpdateAsync(productEditDto.Id, productEditDto);
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
		[Route("GetAllProducts")]
		public async Task<IActionResult> GetAll()
		{
			var result = await _service.GetAllAsync();
			return Ok(result);
		}
	}
}
