using MaSV_NguyenVanTeo.Api.Database;
using MaSV_NguyenVanTeo.Api.Database.Entities;
using MaSV_NguyenVanTeo.Api.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MaSV_NguyenVanTeo.Api.Controllers
{
    [Route("api/mon-hoc")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        DatabaseContext db;

        public MonHocController(DatabaseContext context)
        {
            db = context;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<MonHocDto>>> GetAll()
        {
            List<MonHocDto> danhSachMonHoc = await db.MonHocs
                .Select(m => new MonHocDto()
                {
                    MonHocId = m.MonHocId,
                    MaMon = m.MaMon,
                    TenMon = m.TenMon,
                    SoTinChi = m.SoTinChi,
                    SoTietLyThuyet = m.SoTietLyThuyet
                })
                .ToListAsync();

            return Ok(danhSachMonHoc);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(MonHocAddDto req)
        {
            MonHocEntity newMonHoc = new MonHocEntity()
            {
                MaMon = req.MaMon,
                TenMon = req.TenMon,
                SoTinChi = req.SoTinChi,
                SoTietLyThuyet = req.SoTietLyThuyet
            };

            await db.MonHocs.AddAsync(newMonHoc);

            await db.SaveChangesAsync();

            return Ok();
        }
    }
}
