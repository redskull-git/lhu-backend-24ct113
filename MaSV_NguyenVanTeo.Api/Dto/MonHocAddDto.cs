using System.ComponentModel.DataAnnotations;

namespace MaSV_NguyenVanTeo.Api.Dto
{
    public class MonHocAddDto
    {
        [Required(ErrorMessage = "Vui lòng nhập mã môn học")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Mã môn học từ 10 đến 20 ký tự")]
        public string MaMon { get; set; } = null!;

        [Required(ErrorMessage = "Vui lòng nhập tên môn học")]
        [StringLength(100)]
        public string TenMon { get; set; } = null!;

        [Range(1, 100, ErrorMessage = "Số tín chỉ từ 1 đến 100")]
        public int SoTinChi { get; set; }

        [Range(0, 100, ErrorMessage = "Số tiết lý thuyết từ 0 đến 100")]
        public int SoTietLyThuyet { get; set; }
    }
}
