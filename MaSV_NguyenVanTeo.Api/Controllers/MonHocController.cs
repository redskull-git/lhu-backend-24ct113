using MaSV_NguyenVanTeo.Api.Dto;
using MaSV_NguyenVanTeo.Api.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MaSV_NguyenVanTeo.Api.Controllers
{
    [Route("api/mon-hoc")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        IMonHocService monHocService;

        public MonHocController(IMonHocService monHocService)
        {
            this.monHocService = monHocService;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<MonHocDto>>> GetAll()
        {
            var danhSachMonHoc = await monHocService.GetAllAsync();

            return Ok(danhSachMonHoc);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(MonHocAddDto req)
        {
            int a = 10;
            int b = 0;
            var c = a / b;

            var isSuccess = await monHocService.AddAsync(req);

            if (isSuccess == true) return Ok();

            return BadRequest();
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(MonHocEditDto req)
        {
            var isSuccess = await monHocService.EditAsync(req);

            if (isSuccess == true) return Ok();

            return BadRequest();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int monHocId)
        {
            var isSuccess = await monHocService.DeleteAsync(monHocId);

            if (isSuccess == true) return Ok();

            return BadRequest();
        }
    }
}
