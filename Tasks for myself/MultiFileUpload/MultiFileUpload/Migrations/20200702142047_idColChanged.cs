using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiFileUpload.Migrations
{
    public partial class idColChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Photos",
                newName: "ImgId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgId",
                table: "Photos",
                newName: "Id");
        }
    }
}
