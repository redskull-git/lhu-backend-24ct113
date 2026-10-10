using MaSV_NguyenVanTeo.Api.Database;
using MaSV_NguyenVanTeo.Api.Database.Entities;
using MaSV_NguyenVanTeo.Api.Dto;
using MaSV_NguyenVanTeo.Api.IServices;
using Microsoft.EntityFrameworkCore;

namespace MaSV_NguyenVanTeo.Api.Services
{
    public class LopHocPhanService : ILopHocPhanService
    {
        DatabaseContext db;

        public LopHocPhanService(DatabaseContext context)
        {
            db = context;
        }

        public async Task<List<LopHocPhanDto>> GetAllAsync()
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

            return danhSachLopHocPhan;
        }

        public async Task<bool> AddAsync(LopHocPhanAddDto req)
        {
            var tonTai = await db.LopHocPhans
                .Where(l => l.MaLopHP == req.MaLopHP)
                .AnyAsync();

            if (tonTai == true)
            {
                return false;
            }

            LopHocPhanEntity newLopHocPhan = new LopHocPhanEntity()
            {
                MonHocId = req.MonHocId,
                MaLopHP = req.MaLopHP,
                HocKy = req.HocKy,
                NamHoc = req.NamHoc,
                SiSoToiDa = req.SiSoToiDa,
                NgayBatDau = req.NgayBatDau,
                NgayKetThuc = req.NgayKetThuc
            };

            await db.LopHocPhans.AddAsync(newLopHocPhan);

            var affected = await db.SaveChangesAsync();

            return affected > 0;
        }

        public async Task<bool> EditAsync(LopHocPhanEditDto req)
        {
            var tonTai = await db.LopHocPhans
                .Where(l => l.MaLopHP == req.MaLopHP && l.LopHocPhanId != req.LopHocPhanId)
                .AnyAsync();

            if (tonTai == true)
            {
                return false;
            }

            var lopHocPhan = await db.LopHocPhans
                .Where(l => l.LopHocPhanId == req.LopHocPhanId)
                .FirstOrDefaultAsync();

            if (lopHocPhan == null)
            {
                return false;
            }

            lopHocPhan.MonHocId = req.MonHocId;
            lopHocPhan.MaLopHP = req.MaLopHP;
            lopHocPhan.HocKy = req.HocKy;
            lopHocPhan.NamHoc = req.NamHoc;
            lopHocPhan.SiSoToiDa = req.SiSoToiDa;

            await db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int lopHocPhanId)
        {
            var lopHocPhan = await db.LopHocPhans
                .Where(l => l.LopHocPhanId == lopHocPhanId)
                .FirstOrDefaultAsync();

            if (lopHocPhan == null)
            {
                return false;
            }

            db.LopHocPhans.Remove(lopHocPhan);

            var affected = await db.SaveChangesAsync();

            return affected > 0;
        }
    }
}
