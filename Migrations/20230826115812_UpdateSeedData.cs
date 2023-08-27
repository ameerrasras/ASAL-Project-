using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 58, 11, 930, DateTimeKind.Local).AddTicks(120), new DateTime(2023, 8, 26, 14, 58, 11, 930, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 58, 11, 930, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 8, 26, 14, 58, 11, 930, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 58, 11, 930, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 8, 26, 14, 58, 11, 930, DateTimeKind.Local).AddTicks(200) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8270), new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 8, 26, 14, 55, 9, 957, DateTimeKind.Local).AddTicks(8340) });
        }
    }
}
