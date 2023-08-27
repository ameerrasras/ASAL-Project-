﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[] { 3, "System", new DateTime(2023, 8, 26, 15, 1, 49, 834, DateTimeKind.Local).AddTicks(7260), "Handles financial matters", false, "System", new DateTime(2023, 8, 26, 15, 1, 49, 834, DateTimeKind.Local).AddTicks(7270), "Finance" });
        }
    }
}
