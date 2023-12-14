using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeenPatch03_Day20.Migrations
{
    public partial class RelationRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_depId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_depId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "depId",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "depId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_depId",
                table: "Employees",
                column: "depId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_depId",
                table: "Employees",
                column: "depId",
                principalTable: "Departments",
                principalColumn: "depId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
