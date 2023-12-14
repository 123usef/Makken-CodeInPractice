using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeenPatch03_Day20.Migrations
{
    public partial class DepatmentToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "deptId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_deptId",
                table: "Employees",
                column: "deptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_deptId",
                table: "Employees",
                column: "deptId",
                principalTable: "Departments",
                principalColumn: "depId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_deptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_deptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "deptId",
                table: "Employees");
        }
    }
}
