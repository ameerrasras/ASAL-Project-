using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 1, 49, 834, DateTimeKind.Local).AddTicks(7200), new DateTime(2023, 8, 26, 15, 1, 49, 834, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 1, 49, 834, DateTimeKind.Local).AddTicks(7260), new DateTime(2023, 8, 26, 15, 1, 49, 834, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 8, 26, 15, 1, 49, 834, DateTimeKind.Local).AddTicks(7260), new DateTime(2023, 8, 26, 15, 1, 49, 834, DateTimeKind.Local).AddTicks(7270) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
