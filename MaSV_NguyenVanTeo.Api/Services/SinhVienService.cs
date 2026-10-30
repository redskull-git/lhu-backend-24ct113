using MaSV_NguyenVanTeo.Api.Database;
using MaSV_NguyenVanTeo.Api.Database.Entities;
using MaSV_NguyenVanTeo.Api.Dto;
using MaSV_NguyenVanTeo.Api.IServices;
using Microsoft.EntityFrameworkCore;

namespace MaSV_NguyenVanTeo.Api.Services
{
    public class SinhVienService : ISinhVienService
    {
        private readonly DatabaseContext db;

        public SinhVienService(DatabaseContext context)
        {
            db = context;
        }

        public async Task<List<SinhVienDto>> GetAllAsync()
        {
            var danhSachSinhVien = await db.SinhViens
                .Select(s => new SinhVienDto
                {
                    SinhVienId = s.SinhVienId,
                    MaSV = s.MaSV,
                    HoTen = s.HoTen,
                    Email = s.Email,
                    NgaySinh = s.NgaySinh,
                    LopSinhHoat = s.LopSinhHoat
                })
                .ToListAsync();

            return danhSachSinhVien;
        }

        public async Task<bool> AddAsync(SinhVienAddDto req)
        {
            var tonTaiSinhVien = await db.SinhViens.AnyAsync(s => s.MaSV == req.MaSV);

            if (tonTaiSinhVien)
            {
                return false;
            }

            var newSinhVien = new SinhVienEntity
            {
                MaSV = req.MaSV.Trim(),
                HoTen = req.HoTen.Trim(),
                Email = req.Email?.Trim() ?? "",
                NgaySinh = req.NgaySinh,
                LopSinhHoat = req.LopSinhHoat?.Trim() ?? ""
            };

            await db.SinhViens.AddAsync(newSinhVien);
            var affected = await db.SaveChangesAsync();

            return affected > 0;
        }

        public async Task<bool> EditAsync(SinhVienEditDto req)
        {
            var tonTaiMaSV = await db.SinhViens
                .AnyAsync(s => s.MaSV == req.MaSV && s.SinhVienId != req.SinhVienId);

            if (tonTaiMaSV)
            {
                return false;
            }

            var sinhVien = await db.SinhViens
                .FirstOrDefaultAsync(s => s.SinhVienId == req.SinhVienId);

            if (sinhVien == null)
            {
                return false;
            }

            sinhVien.MaSV = req.MaSV.Trim();
            sinhVien.HoTen = req.HoTen.Trim();
            sinhVien.Email = req.Email?.Trim() ?? "";
            sinhVien.NgaySinh = req.NgaySinh;
            sinhVien.LopSinhHoat = req.LopSinhHoat?.Trim() ?? "";

            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int sinhVienId)
        {
            var sinhVien = await db.SinhViens
                .FirstOrDefaultAsync(s => s.SinhVienId == sinhVienId);

            if (sinhVien == null)
            {
                return false;
            }

            // Chặn xóa nếu sinh viên đã có lịch sử đăng ký học phần
            var coDangKyHocPhan = await db.DangKies.AnyAsync(d => d.SinhVienId == sinhVienId);
            if (coDangKyHocPhan)
            {
                return false;
            }

            // Chặn xóa nếu sinh viên đã được cấp tài khoản người dùng
            var coTaiKhoan = await db.NguoiDungs.AnyAsync(u => u.SinhVienId == sinhVienId);
            if (coTaiKhoan)
            {
                return false;
            }

            db.SinhViens.Remove(sinhVien);
            var affected = await db.SaveChangesAsync();

            return affected > 0;
        }
    }
}
