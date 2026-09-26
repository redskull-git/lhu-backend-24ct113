using Microsoft.EntityFrameworkCore;
using MaSV_NguyenVanTeo.Api.Database.Seeds;
using MaSV_NguyenVanTeo.Api.Database.Entities;

namespace MaSV_NguyenVanTeo.Api.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<MonHocEntity> MonHocs => Set<MonHocEntity>();

        public DbSet<LopHocPhanEntity> LopHocPhans => Set<LopHocPhanEntity>();

        public DbSet<SinhVienEntity> SinhViens => Set<SinhVienEntity>();

        public DbSet<DangKyEntity> DangKies => Set<DangKyEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
        }
    }
}
