using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaSV_NguyenVanTeo.Api.Migrations
{
    /// <inheritdoc />
    public partial class SinhVienUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_MaSV",
                table: "SinhVien",
                column: "MaSV",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SinhVien_MaSV",
                table: "SinhVien");
        }
    }
}
