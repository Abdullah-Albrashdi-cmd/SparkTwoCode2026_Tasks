using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class CreateMissedTableUpdateRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "employees",
                newName: "EmployeeSex");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeAddress",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeBirthDate",
                table: "employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EmployeeFname",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeLname",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeMinit",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentLocation",
                table: "department",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentMgr_ssn",
                table: "department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentMgr_start_date",
                table: "department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "dependent",
                columns: table => new
                {
                    DependentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DependentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeSsn = table.Column<int>(type: "int", nullable: false),
                    DependentSex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DependentBirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DependentRelationship = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependent", x => x.DependentId);
                });

            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "works_on",
                columns: table => new
                {
                    WorksOnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorksOnSsn = table.Column<int>(type: "int", nullable: false),
                    WorksOnProjectNo = table.Column<int>(type: "int", nullable: false),
                    WorksOnHours = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_works_on", x => x.WorksOnId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dependent");

            migrationBuilder.DropTable(
                name: "project");

            migrationBuilder.DropTable(
                name: "works_on");

            migrationBuilder.DropColumn(
                name: "EmployeeAddress",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeBirthDate",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeFname",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeLname",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeMinit",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DepartmentLocation",
                table: "department");

            migrationBuilder.DropColumn(
                name: "DepartmentMgr_ssn",
                table: "department");

            migrationBuilder.DropColumn(
                name: "DepartmentMgr_start_date",
                table: "department");

            migrationBuilder.RenameColumn(
                name: "EmployeeSex",
                table: "employees",
                newName: "EmployeeName");
        }
    }
}
