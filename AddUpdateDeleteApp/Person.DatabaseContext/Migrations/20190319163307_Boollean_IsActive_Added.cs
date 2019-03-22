using Microsoft.EntityFrameworkCore.Migrations;

namespace Person.DatabaseContext.Migrations
{
    public partial class Boollean_IsActive_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
