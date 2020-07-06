using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addKokkbazId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KookBaz_Id",
                schema: "KookBaz",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KookBaz_Id",
                schema: "KookBaz",
                table: "Orders");
        }
    }
}
