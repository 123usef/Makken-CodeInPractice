using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeenPatch03_Day20.Migrations
{
    public partial class manyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentdepId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentdepId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    EmployeesEmployeeID = table.Column<int>(type: "int", nullable: false),
                    projectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => new { x.EmployeesEmployeeID, x.projectsId });
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_EmployeesEmployeeID",
                        column: x => x.EmployeesEmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Projects_projectsId",
                        column: x => x.projectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentdepId",
                table: "Employees",
                column: "DepartmentdepId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentdepId1",
                table: "Employees",
                column: "DepartmentdepId1");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_projectsId",
                table: "EmployeeProjects",
                column: "projectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentdepId",
                table: "Employees",
                column: "DepartmentdepId",
                principalTable: "Departments",
                principalColumn: "depId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentdepId1",
                table: "Employees",
                column: "DepartmentdepId1",
                principalTable: "Departments",
                principalColumn: "depId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentdepId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentdepId1",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentdepId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentdepId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentdepId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentdepId1",
                table: "Employees");
        }
    }
}
