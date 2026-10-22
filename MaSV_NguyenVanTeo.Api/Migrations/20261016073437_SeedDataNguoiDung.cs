using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaSV_NguyenVanTeo.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataNguoiDung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NguoiDung",
                columns: new[] { "Id", "GiangVienId", "HoTen", "MatKhauHash", "SinhVienId", "TenDangNhap", "VaiTro" },
                values: new object[,]
                {
                    { 1, null, "Phòng Đào Tạo", "$2a$11$ToDL5Apm.cdz0RUOZggDkenlORElj.PA6qx1gZ7G5Yj5XQdhNml46", null, "daotao", "DaoTao" },
                    { 2, 1, "ThS. Trần Văn Giảng", "$2a$11$ToDL5Apm.cdz0RUOZggDkenlORElj.PA6qx1gZ7G5Yj5XQdhNml46", null, "giangvien", "GiangVien" },
                    { 3, null, "Nguyễn Văn Tèo", "$2a$11$ToDL5Apm.cdz0RUOZggDkenlORElj.PA6qx1gZ7G5Yj5XQdhNml46", 1, "sinhvien", "SinhVien" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NguoiDung",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NguoiDung",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NguoiDung",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
