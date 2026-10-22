using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaSV_NguyenVanTeo.Api.Database.Entities
{
    [Table("NguoiDung")]
    [Index(nameof(TenDangNhap), IsUnique = true)]
    public class NguoiDungEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; } = null!; // Mã sinh viên hoặc mã cán bộ

        [Required]
        [StringLength(255)]
        public string MatKhauHash { get; set; } = null!; // Chuỗi băm BCrypt

        [Required]
        [StringLength(20)]
        public string VaiTro { get; set; } = null!; // "SinhVien", "GiangVien", "DaoTao"

        // Khóa ngoại liên kết hồ sơ Sinh viên tương ứng (nếu là vai trò Sinh viên)
        public int? SinhVienId { get; set; }

        [ForeignKey(nameof(SinhVienId))]
        public SinhVienEntity? SinhVien { get; set; }

        // Khóa ngoại liên kết hồ sơ Giảng viên (nếu là vai trò Giảng viên)
        public int? GiangVienId { get; set; }
    }
}
