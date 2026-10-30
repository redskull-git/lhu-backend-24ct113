using MaSV_NguyenVanTeo.Api.Dto;
using MaSV_NguyenVanTeo.Api.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaSV_NguyenVanTeo.Api.Controllers
{
    [Route("api/sinh-vien")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly ISinhVienService sinhVienService;

        public SinhVienController(ISinhVienService sinhVienService)
        {
            this.sinhVienService = sinhVienService;
        }

        // Cho phép cả Sinh viên, Giảng viên và Đào tạo cùng xem danh sách sinh viên
        [Authorize(Roles = "SinhVien,GiangVien,DaoTao")]
        [HttpGet("get-all")]
        public async Task<ActionResult<List<SinhVienDto>>> GetAll()
        {
            var danhSachSinhVien = await sinhVienService.GetAllAsync();

            return Ok(danhSachSinhVien);
        }

        // Chỉ có Phòng Đào tạo mới có quyền thêm mới sinh viên
        [Authorize(Roles = "DaoTao")]
        [HttpPost("add")]
        public async Task<IActionResult> Add(SinhVienAddDto req)
        {
            var isSuccess = await sinhVienService.AddAsync(req);

            if (isSuccess) return Ok();

            return BadRequest(new { message = "Mã sinh viên đã tồn tại hoặc dữ liệu không hợp lệ." });
        }

        // Chỉ có Phòng Đào tạo mới có quyền chỉnh sửa thông tin sinh viên
        [Authorize(Roles = "DaoTao")]
        [HttpPut("edit")]
        public async Task<IActionResult> Edit(SinhVienEditDto req)
        {
            var isSuccess = await sinhVienService.EditAsync(req);

            if (isSuccess) return Ok();

            return BadRequest(new { message = "Không tìm thấy sinh viên hoặc mã sinh viên bị trùng." });
        }

        // Chỉ có Phòng Đào tạo mới có quyền xóa sinh viên
        [Authorize(Roles = "DaoTao")]
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int sinhVienId)
        {
            var isSuccess = await sinhVienService.DeleteAsync(sinhVienId);

            if (isSuccess) return Ok();

            return BadRequest(new { message = "Không thể xóa sinh viên do không tồn tại hoặc đã có dữ liệu đăng ký/tài khoản." });
        }
    }
}
