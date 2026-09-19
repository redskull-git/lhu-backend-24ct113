using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaSV_NguyenVanTeo.Api.Database.Entities
{
    [Table("MonHoc")]
    public class MonHocEntity
    {
        [Key]
        public int MonHocId { get; set; }

        [Required]
        [MaxLength(20)]
        public string MaMon { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string TenMon { get; set; } = null!;

        public int SoTinChi { get; set; }

        public int SoTietLyThuyet { get; set; }

        public ICollection<LopHocPhanEntity> LopHocPhans { get; set; } = [];
    }
}
