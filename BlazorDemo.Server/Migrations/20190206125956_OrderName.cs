using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorDemo.Server.Migrations
{
    public partial class OrderName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ORDER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ORDER");
        }
    }
}
