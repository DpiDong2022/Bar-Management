using Microsoft.EntityFrameworkCore.Migrations;

namespace Bar_Management.Migrations
{
    public partial class updateTaiKhoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TaiKhoans",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TaiKhoans");
        }
    }
}
