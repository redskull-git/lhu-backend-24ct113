using MaSV_NguyenVanTeo.Api.Database;
using MaSV_NguyenVanTeo.Api.Database.Entities;
using MaSV_NguyenVanTeo.Api.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MaSV_NguyenVanTeo.Api.Controllers
{
    [Route("api/lop-hoc-phan")]
    [ApiController]
    public class LopHocPhanController : ControllerBase
    {
        DatabaseContext db;

        public LopHocPhanController(DatabaseContext context)
        {
            db = context;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<LopHocPhanDto>>> GetAll()
        {
            List<LopHocPhanDto> danhSachLopHocPhan = await db.LopHocPhans
                .Select(l => new LopHocPhanDto()
                {
                    LopHocPhanId = l.LopHocPhanId,
                    MonHocId = l.MonHocId,
                    MaLopHP = l.MaLopHP,
                    HocKy = l.HocKy,
                    NamHoc = l.NamHoc,
                    SiSoToiDa = l.SiSoToiDa
                })
                .ToListAsync();

            return Ok(danhSachLopHocPhan);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(LopHocPhanAddDto req)
        {
            LopHocPhanEntity newLopHocPhan = new LopHocPhanEntity()
            {
                MonHocId = req.MonHocId,
                MaLopHP = req.MaLopHP,
                HocKy = req.HocKy,
                NamHoc = req.NamHoc,
                SiSoToiDa = req.SiSoToiDa
            };

            await db.LopHocPhans.AddAsync(newLopHocPhan);

            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("edit")]
        public async Task<IActionResult> Edit(LopHocPhanEditDto req)
        {
            var lopHocPhan = await db.LopHocPhans
                .Where(l => l.LopHocPhanId == req.LopHocPhanId)
                .FirstOrDefaultAsync();

            if (lopHocPhan == null)
            {
                return NotFound();
            }

            lopHocPhan.MonHocId = req.MonHocId;
            lopHocPhan.MaLopHP = req.MaLopHP;
            lopHocPhan.HocKy = req.HocKy;
            lopHocPhan.NamHoc = req.NamHoc;
            lopHocPhan.SiSoToiDa = req.SiSoToiDa;

            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int lopHocPhanId)
        {
            var lopHocPhan = await db.LopHocPhans
                .Where(l => l.LopHocPhanId == lopHocPhanId)
                .FirstOrDefaultAsync();

            if (lopHocPhan == null)
            {
                return NotFound();
            }

            db.LopHocPhans.Remove(lopHocPhan);

            await db.SaveChangesAsync();

            return Ok();
        }
    }
}
