using MaSV_NguyenVanTeo.Api.Dto;
using MaSV_NguyenVanTeo.Api.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MaSV_NguyenVanTeo.Api.Controllers
{
    [Route("api/lop-hoc-phan")]
    [ApiController]
    public class LopHocPhanController : ControllerBase
    {
        ILopHocPhanService lopHocPhanService;

        public LopHocPhanController(ILopHocPhanService lopHocPhanService)
        {
            this.lopHocPhanService = lopHocPhanService;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<LopHocPhanDto>>> GetAll()
        {
            var danhSachLopHocPhan = await lopHocPhanService.GetAllAsync();

            return Ok(danhSachLopHocPhan);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(LopHocPhanAddDto req)
        {
            var isSuccess = await lopHocPhanService.AddAsync(req);

            if (isSuccess == true) return Ok();

            return BadRequest();
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(LopHocPhanEditDto req)
        {
            var isSuccess = await lopHocPhanService.EditAsync(req);

            if (isSuccess == true) return Ok();

            return BadRequest();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int lopHocPhanId)
        {
            var isSuccess = await lopHocPhanService.DeleteAsync(lopHocPhanId);

            if (isSuccess == true) return Ok();

            return BadRequest();
        }
    }
}
