using Microsoft.EntityFrameworkCore.Migrations;

namespace AppASPMVCCore.Migrations
{
    public partial class @fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServicePhotoId",
                table: "Services");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServicePhotoId",
                table: "Services",
                nullable: false,
                defaultValue: 0);
        }
    }
}
