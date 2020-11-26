using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiFileUpload.Migrations
{
    public partial class updateed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "Photos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "Photos",
                nullable: false,
                defaultValue: "");
        }
    }
}
