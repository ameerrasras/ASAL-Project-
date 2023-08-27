using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDatal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 18, 2, 886, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 8, 26, 15, 18, 2, 886, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 18, 2, 886, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 8, 26, 15, 18, 2, 886, DateTimeKind.Local).AddTicks(8950) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 16, 20, 888, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 8, 26, 15, 16, 20, 888, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 16, 20, 888, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 8, 26, 15, 16, 20, 888, DateTimeKind.Local).AddTicks(5320) });
        }
    }
}
