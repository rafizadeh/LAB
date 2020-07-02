using Microsoft.EntityFrameworkCore.Migrations;

namespace lab30062020.Migrations
{
    public partial class attributesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Photos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Photos",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
