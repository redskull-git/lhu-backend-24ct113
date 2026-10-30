using System.ComponentModel.DataAnnotations;

namespace MaSV_NguyenVanTeo.Api.Dto
{
    public class SinhVienAddDto
    {
        [Required(ErrorMessage = "Vui lòng nhập mã sinh viên")]
        [StringLength(20, ErrorMessage = "Mã sinh viên tối đa 20 ký tự")]
        public string MaSV { get; set; } = null!;

        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        [StringLength(100, ErrorMessage = "Họ tên tối đa 100 ký tự")]
        public string HoTen { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Định dạng email không hợp lệ")]
        [StringLength(100, ErrorMessage = "Email tối đa 100 ký tự")]
        public string? Email { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(50, ErrorMessage = "Lớp sinh hoạt tối đa 50 ký tự")]
        public string? LopSinhHoat { get; set; }
    }
}
