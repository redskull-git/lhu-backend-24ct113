using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaSV_NguyenVanTeo.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MonHoc",
                columns: new[] { "MonHocId", "MaMon", "SoTietLyThuyet", "SoTinChi", "TenMon" },
                values: new object[,]
                {
                    { 1, "COS101", 45, 3, "Nhập môn lập trình" },
                    { 2, "COS102", 45, 3, "Kỹ thuật lập trình" },
                    { 3, "COS201", 60, 4, "Cấu trúc dữ liệu và giải thuật" },
                    { 4, "COS202", 45, 3, "Lập trình hướng đối tượng" },
                    { 5, "DBS201", 45, 3, "Cơ sở dữ liệu" },
                    { 6, "DBS202", 45, 3, "Hệ quản trị cơ sở dữ liệu" },
                    { 7, "NET201", 45, 3, "Mạng máy tính" },
                    { 8, "OPS201", 45, 3, "Hệ điều hành" },
                    { 9, "WEB301", 45, 3, "Phát triển ứng dụng Web" },
                    { 10, "DOT301", 45, 3, "Lập trình .NET nâng cao" }
                });

            migrationBuilder.InsertData(
                table: "LopHocPhan",
                columns: new[] { "LopHocPhanId", "HocKy", "MaLopHP", "MonHocId", "NamHoc", "SiSoToiDa" },
                values: new object[,]
                {
                    { 1, 1, "LHP_COS101_01", 1, 2025, 60 },
                    { 2, 1, "LHP_COS101_02", 1, 2025, 55 },
                    { 3, 2, "LHP_COS102_01", 2, 2025, 60 },
                    { 4, 2, "LHP_COS102_02", 2, 2025, 50 },
                    { 5, 1, "LHP_COS201_01", 3, 2025, 60 },
                    { 6, 2, "LHP_COS201_02", 3, 2025, 60 },
                    { 7, 1, "LHP_COS202_01", 4, 2025, 65 },
                    { 8, 1, "LHP_DBS201_01", 5, 2025, 70 },
                    { 9, 2, "LHP_DBS201_02", 5, 2025, 65 },
                    { 10, 2, "LHP_DBS202_01", 6, 2025, 50 },
                    { 11, 1, "LHP_NET201_01", 7, 2025, 60 },
                    { 12, 2, "LHP_OPS201_01", 8, 2025, 60 },
                    { 13, 1, "LHP_WEB301_01", 9, 2025, 50 },
                    { 14, 1, "LHP_DOT301_01", 10, 2025, 55 },
                    { 15, 2, "LHP_DOT301_02", 10, 2025, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LopHocPhan",
                keyColumn: "LopHocPhanId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MonHoc",
                keyColumn: "MonHocId",
                keyValue: 10);
        }
    }
}
