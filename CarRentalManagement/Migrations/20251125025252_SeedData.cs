using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8217), new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8233), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8235), new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8236), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8531), new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8532), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8534), new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8535), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8675), new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8675), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8678), new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8678), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8680), new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8681), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8682), new DateTime(2025, 11, 25, 10, 52, 51, 24, DateTimeKind.Local).AddTicks(8683), "C-HR", "System" }
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
