using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaSV_NguyenVanTeo.Api.Migrations
{
    /// <inheritdoc />
    public partial class BoHoTenKhoiNguoiDung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoTen",
                table: "NguoiDung");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HoTen",
                table: "NguoiDung",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "Id",
                keyValue: 1,
                column: "HoTen",
                value: "Phòng Đào Tạo");

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "Id",
                keyValue: 2,
                column: "HoTen",
                value: "ThS. Trần Văn Giảng");

            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "Id",
                keyValue: 3,
                column: "HoTen",
                value: "Nguyễn Văn Tèo");
        }
    }
}
