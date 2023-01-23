using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmitWebAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: true),
                    AddOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddOn", "Department", "Email", "HireDate", "Job", "Name", "RecStatus", "Salary", "UpdateOn" },
                values: new object[] { 1, new DateTime(2023, 1, 23, 9, 59, 47, 471, DateTimeKind.Local).AddTicks(6946), 1, "amit.sircltech@.com", new DateTime(2023, 1, 23, 9, 59, 47, 471, DateTimeKind.Local).AddTicks(6975), "Programmer", "Amit", 1, 50000m, new DateTime(2023, 1, 23, 9, 59, 47, 471, DateTimeKind.Local).AddTicks(6963) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
