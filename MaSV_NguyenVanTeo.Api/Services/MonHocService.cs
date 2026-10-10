using MaSV_NguyenVanTeo.Api.Database;
using MaSV_NguyenVanTeo.Api.Database.Entities;
using MaSV_NguyenVanTeo.Api.Dto;
using MaSV_NguyenVanTeo.Api.IServices;
using Microsoft.EntityFrameworkCore;

namespace MaSV_NguyenVanTeo.Api.Services
{
    public class MonHocService : IMonHocService
    {
        DatabaseContext db;

        public MonHocService(DatabaseContext context)
        {
            db = context;
        }

        public async Task<bool> AddAsync(MonHocAddDto req)
        {
            var tonTaiMonHoc = await db.MonHocs.Where(m => m.MaMon == req.MaMon).AnyAsync();

            if(tonTaiMonHoc ==  true)
            {
                return false;
            }

            MonHocEntity newMonHoc = new MonHocEntity()
            {
                MaMon = req.MaMon,
                TenMon = req.TenMon,
                SoTinChi = req.SoTinChi,
                SoTietLyThuyet = req.SoTietLyThuyet
            };

            await db.MonHocs.AddAsync(newMonHoc);

            var affected = await db.SaveChangesAsync();

            if (affected > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int monHocId)
        {
            var monHoc = await db.MonHocs
                .Where(m => m.MonHocId == monHocId)
                .FirstOrDefaultAsync();

            if (monHoc == null)
            {
                return false;
            }

            db.MonHocs.Remove(monHoc);

            var affedted = await db.SaveChangesAsync();

            return affedted > 0;
        }

        public async Task<bool> EditAsync(MonHocEditDto req)
        {
            var tonTaiMonHoc = await db.MonHocs
                .Where(m => m.MaMon == req.MaMon && m.MonHocId != req.MonHocId)
                .AnyAsync();

            if (tonTaiMonHoc == true)
            {
                return false;
            }

            var monHoc = await db.MonHocs
                .Where(m => m.MonHocId == req.MonHocId)
                .FirstOrDefaultAsync();

            if (monHoc == null)
            {
                return false;
            }

            monHoc.MaMon = req.MaMon;
            monHoc.TenMon = req.TenMon;
            monHoc.SoTinChi = req.SoTinChi;
            monHoc.SoTietLyThuyet = req.SoTietLyThuyet;

            await db.SaveChangesAsync();

            return true;
        }

        public async Task<List<MonHocDto>> GetAllAsync()
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

            return danhSachMonHoc;
        }
    }
}
