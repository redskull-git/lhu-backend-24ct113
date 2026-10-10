using Dapper;
using MaSV_NguyenVanTeo.Api.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace MaSV_NguyenVanTeo.Api.Controllers
{
    [Route("api/dang-ky")]
    [ApiController]
    public class DangKyController : ControllerBase
    {
        SqlConnection cn;

        public DangKyController(SqlConnection cn)
        {
            this.cn = cn;
        }

        [HttpPost("them-moi")]
        public async Task<IActionResult> ThemMoi(DangKyThemMoiDto req)
        {
            var param = new DynamicParameters();

            param.Add("@SinhVienId", req.SinhVienId, dbType: DbType.Int32);
            param.Add("@LopHocPhanId", req.LopHocPhanId, dbType: DbType.Int32);
            param.Add("@KetQua", dbType: DbType.Int32, direction: ParameterDirection.Output);
            param.Add("@ThongBao", dbType: DbType.String, direction: ParameterDirection.Output, size: 255);

            await cn.ExecuteAsync(sql: "sp_DangKyHocPhan", param);

            int ketQua = param.Get<int>("@KetQua");
            string thongBao = param.Get<string>("@ThongBao");

            if (ketQua == 1) return Ok();

            return BadRequest(thongBao);
        }
    }
}
