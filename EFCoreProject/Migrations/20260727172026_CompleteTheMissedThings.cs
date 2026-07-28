using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class CompleteTheMissedThings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "works_on");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dependent",
                table: "dependent");

            migrationBuilder.DropColumn(
                name: "DepartmentLocation",
                table: "department");

            migrationBuilder.RenameColumn(
                name: "EmployeeSsn",
                table: "dependent",
                newName: "EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "DependentName",
                table: "dependent",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DependentId",
                table: "dependent",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ManageStartDate",
                table: "department",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_dependent",
                table: "dependent",
                columns: new[] { "DependentId", "DependentName" });

            migrationBuilder.CreateTable(
                name: "deptLocations",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DepartmentLocation = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deptLocations", x => new { x.DepartmentId, x.DepartmentLocation });
                    table.ForeignKey(
                        name: "FK_deptLocations_department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "worksOnEmpProjs",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worksOnEmpProjs", x => new { x.EmployeeId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_worksOnEmpProjs_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_worksOnEmpProjs_project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_project_DepartmentId",
                table: "project",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentId",
                table: "employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_SupervisorId",
                table: "employees",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_dependent_EmployeeId",
                table: "dependent",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_department_EmployeeId",
                table: "department",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_worksOnEmpProjs_ProjectId",
                table: "worksOnEmpProjs",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_department_employees_EmployeeId",
                table: "department",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dependent_employees_EmployeeId",
                table: "dependent",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_department_DepartmentId",
                table: "employees",
                column: "DepartmentId",
                principalTable: "department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_employees_SupervisorId",
                table: "employees",
                column: "SupervisorId",
                principalTable: "employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_project_department_DepartmentId",
                table: "project",
                column: "DepartmentId",
                principalTable: "department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_employees_EmployeeId",
                table: "department");

            migrationBuilder.DropForeignKey(
                name: "FK_dependent_employees_EmployeeId",
                table: "dependent");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_department_DepartmentId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_employees_SupervisorId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_project_department_DepartmentId",
                table: "project");

            migrationBuilder.DropTable(
                name: "deptLocations");

            migrationBuilder.DropTable(
                name: "worksOnEmpProjs");

            migrationBuilder.DropIndex(
                name: "IX_project_DepartmentId",
                table: "project");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmentId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_SupervisorId",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dependent",
                table: "dependent");

            migrationBuilder.DropIndex(
                name: "IX_dependent_EmployeeId",
                table: "dependent");

            migrationBuilder.DropIndex(
                name: "IX_department_EmployeeId",
                table: "department");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "project");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "department");

            migrationBuilder.DropColumn(
                name: "ManageStartDate",
                table: "department");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "dependent",
                newName: "EmployeeSsn");

            migrationBuilder.AlterColumn<string>(
                name: "DependentName",
                table: "dependent",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "DependentId",
                table: "dependent",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentLocation",
                table: "department",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dependent",
                table: "dependent",
                column: "DependentId");

            migrationBuilder.CreateTable(
                name: "works_on",
                columns: table => new
                {
                    WorksOnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorksOnHours = table.Column<double>(type: "float", nullable: false),
                    WorksOnProjectNo = table.Column<int>(type: "int", nullable: false),
                    WorksOnSsn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_works_on", x => x.WorksOnId);
                });
        }
    }
}
