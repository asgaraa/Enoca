using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Firma;
using ServiceLayer.DTOs.Order;
using ServiceLayer.Services.Interfaces;

namespace EnocaApi.Controllers
{

    public class OrderController : BaseController
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateOrder")]
        public async Task<IActionResult> Create([FromBody] OrderDto orderDto)
        {
            await _service.CreateAsync(orderDto);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteOrder/{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            await _service.DeleteAsync(id);

            return Ok();
        }
        [HttpPut]
        [Route("UpdateOrder")]
        public async Task<IActionResult> Update([FromBody] OrderEditDto orderEditDto)
        {


            await _service.UpdateAsync(orderEditDto.Id, orderEditDto);
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
        [Route("GetAllOrders")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
    }
}
