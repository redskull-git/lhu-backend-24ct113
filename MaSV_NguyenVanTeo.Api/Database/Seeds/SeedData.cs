using MaSV_NguyenVanTeo.Api.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace MaSV_NguyenVanTeo.Api.Database.Seeds
{
    public static class SeedData
    {
        // ==========================================
        // 10 Records MonHoc
        // ==========================================
        public static readonly List<MonHocEntity> MonHocList = new()
        {
            new MonHocEntity
            {
                MonHocId = 1,
                MaMon = "COS101",
                TenMon = "Nhập môn lập trình",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            },
            new MonHocEntity
            {
                MonHocId = 2,
                MaMon = "COS102",
                TenMon = "Kỹ thuật lập trình",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            },
            new MonHocEntity
            {
                MonHocId = 3,
                MaMon = "COS201",
                TenMon = "Cấu trúc dữ liệu và giải thuật",
                SoTinChi = 4,
                SoTietLyThuyet = 60
            },
            new MonHocEntity
            {
                MonHocId = 4,
                MaMon = "COS202",
                TenMon = "Lập trình hướng đối tượng",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            },
            new MonHocEntity
            {
                MonHocId = 5,
                MaMon = "DBS201",
                TenMon = "Cơ sở dữ liệu",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            },
            new MonHocEntity
            {
                MonHocId = 6,
                MaMon = "DBS202",
                TenMon = "Hệ quản trị cơ sở dữ liệu",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            },
            new MonHocEntity
            {
                MonHocId = 7,
                MaMon = "NET201",
                TenMon = "Mạng máy tính",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            },
            new MonHocEntity
            {
                MonHocId = 8,
                MaMon = "OPS201",
                TenMon = "Hệ điều hành",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            },
            new MonHocEntity
            {
                MonHocId = 9,
                MaMon = "WEB301",
                TenMon = "Phát triển ứng dụng Web",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            },
            new MonHocEntity
            {
                MonHocId = 10,
                MaMon = "DOT301",
                TenMon = "Lập trình .NET nâng cao",
                SoTinChi = 3,
                SoTietLyThuyet = 45
            }
        };

        // ==========================================
        // 15 Records LopHocPhan
        // ==========================================
        public static readonly List<LopHocPhanEntity> LopHocPhanList = new()
        {
            new LopHocPhanEntity
            {
                LopHocPhanId = 1,
                MonHocId = 1,
                MaLopHP = "LHP_COS101_01",
                HocKy = 1,
                NamHoc = 2025,
                SiSoToiDa = 60
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 2,
                MonHocId = 1,
                MaLopHP = "LHP_COS101_02",
                HocKy = 1,
                NamHoc = 2025,
                SiSoToiDa = 55
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 3,
                MonHocId = 2,
                MaLopHP = "LHP_COS102_01",
                HocKy = 2,
                NamHoc = 2025,
                SiSoToiDa = 60
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 4,
                MonHocId = 2,
                MaLopHP = "LHP_COS102_02",
                HocKy = 2,
                NamHoc = 2025,
                SiSoToiDa = 50
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 5,
                MonHocId = 3,
                MaLopHP = "LHP_COS201_01",
                HocKy = 1,
                NamHoc = 2025,
                SiSoToiDa = 60
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 6,
                MonHocId = 3,
                MaLopHP = "LHP_COS201_02",
                HocKy = 2,
                NamHoc = 2025,
                SiSoToiDa = 60
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 7,
                MonHocId = 4,
                MaLopHP = "LHP_COS202_01",
                HocKy = 1,
                NamHoc = 2025,
                SiSoToiDa = 65
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 8,
                MonHocId = 5,
                MaLopHP = "LHP_DBS201_01",
                HocKy = 1,
                NamHoc = 2025,
                SiSoToiDa = 70
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 9,
                MonHocId = 5,
                MaLopHP = "LHP_DBS201_02",
                HocKy = 2,
                NamHoc = 2025,
                SiSoToiDa = 65
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 10,
                MonHocId = 6,
                MaLopHP = "LHP_DBS202_01",
                HocKy = 2,
                NamHoc = 2025,
                SiSoToiDa = 50
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 11,
                MonHocId = 7,
                MaLopHP = "LHP_NET201_01",
                HocKy = 1,
                NamHoc = 2025,
                SiSoToiDa = 60
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 12,
                MonHocId = 8,
                MaLopHP = "LHP_OPS201_01",
                HocKy = 2,
                NamHoc = 2025,
                SiSoToiDa = 60
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 13,
                MonHocId = 9,
                MaLopHP = "LHP_WEB301_01",
                HocKy = 1,
                NamHoc = 2025,
                SiSoToiDa = 50
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 14,
                MonHocId = 10,
                MaLopHP = "LHP_DOT301_01",
                HocKy = 1,
                NamHoc = 2025,
                SiSoToiDa = 55
            },
            new LopHocPhanEntity
            {
                LopHocPhanId = 15,
                MonHocId = 10,
                MaLopHP = "LHP_DOT301_02",
                HocKy = 2,
                NamHoc = 2025,
                SiSoToiDa = 50
            }
        };

        /// <summary>
        /// Cấu hình Seed data cho ModelBuilder (EF Core Migrations HasData).
        /// Sử dụng trong DatabaseContext.OnModelCreating: modelBuilder.Seed();
        /// </summary>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonHocEntity>().HasData(MonHocList);
            modelBuilder.Entity<LopHocPhanEntity>().HasData(LopHocPhanList);
        }

        /// <summary>
        /// Khởi tạo và nạp Seed data khi ứng dụng khởi chạy (Runtime Seeding).
        /// Gọi trong Program.cs: SeedData.Initialize(context);
        /// </summary>
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            if (!context.MonHocs.Any())
            {
                context.MonHocs.AddRange(MonHocList);
                context.SaveChanges();
            }

            if (!context.LopHocPhans.Any())
            {
                context.LopHocPhans.AddRange(LopHocPhanList);
                context.SaveChanges();
            }
        }
    }

    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context) => SeedData.Initialize(context);
    }
}
