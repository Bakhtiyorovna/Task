using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Service.DTOs.Warehouses;
using Task.Service.Interfaces.Warehouses;

namespace Task.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseProductDetailController : ControllerBase
    {
        private readonly IWarehouseProductDetailService _warehouseProductDetailService;
        public WarehouseProductDetailController(IWarehouseProductDetailService warehouseProductDetailService)
        {
            this._warehouseProductDetailService = warehouseProductDetailService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromForm] WarehouseProductCreateDto dto)
        => Ok(await _warehouseProductDetailService.CreateAsync(dto));
    }
}
