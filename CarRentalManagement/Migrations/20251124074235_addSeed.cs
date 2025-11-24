using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class addSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(1634), new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(1651), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(1654), new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(1655), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2266), new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2268), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2270), new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2271), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2111), new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2114), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2117), new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2118), "x5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2120), new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2121), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2123), new DateTime(2025, 11, 24, 15, 42, 33, 961, DateTimeKind.Local).AddTicks(2124), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
