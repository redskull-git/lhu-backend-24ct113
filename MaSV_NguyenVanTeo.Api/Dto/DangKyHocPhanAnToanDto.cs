using System.ComponentModel.DataAnnotations;

namespace MaSV_NguyenVanTeo.Api.Dto
{
    public class DangKyHocPhanAnToanDto
    {
        [Required(ErrorMessage = "Vui lòng chọn lớp học phần cần đăng ký.")]
        public int LopHocPhanId { get; set; }
    }
}
