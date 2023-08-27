using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8270), new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 2, "System", new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8340), "Human Resources", false, "System", new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8340), "HR" },
                    { 3, "System", new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8340), "Handles financial matters", false, "System", new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8340), "Finance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 51, 44, 546, DateTimeKind.Local).AddTicks(7580), new DateTime(2023, 8, 26, 14, 51, 44, 546, DateTimeKind.Local).AddTicks(7640) });
        }
    }
}
