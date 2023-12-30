using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDcodefirst.Migrations
{
    public partial class updateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "age",
                table: "Students",
                newName: "Age");

            migrationBuilder.AddColumn<int>(
                name: "Standard",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standard",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Students",
                newName: "age");
        }
    }
}
