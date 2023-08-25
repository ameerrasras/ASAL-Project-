using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[] { 1, "System", new DateTime(2023, 8, 24, 20, 22, 41, 143, DateTimeKind.Local).AddTicks(6410), "Handles all engineering stuff", false, "System", new DateTime(2023, 8, 24, 20, 22, 41, 143, DateTimeKind.Local).AddTicks(6470), "Engineering" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
