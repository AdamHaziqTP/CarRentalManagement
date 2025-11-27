using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b76c95b3-72dc-4ed6-8caf-6c49be5825b7", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMJcCAqShcjfPNYOAiQRsT2sVX/9gN4pXiktgfOUVC8Umob7CJtw1vSFBk6cHB2tcQ==", null, false, "46e729f3-97f4-4719-a1c4-03fbd0dc19d0", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 49, 44, 670, DateTimeKind.Local).AddTicks(9302), new DateTime(2025, 11, 27, 13, 49, 44, 670, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 49, 44, 670, DateTimeKind.Local).AddTicks(9323), new DateTime(2025, 11, 27, 13, 49, 44, 670, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 49, 44, 670, DateTimeKind.Local).AddTicks(9795), new DateTime(2025, 11, 27, 13, 49, 44, 670, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 49, 44, 670, DateTimeKind.Local).AddTicks(9800), new DateTime(2025, 11, 27, 13, 49, 44, 670, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 49, 44, 671, DateTimeKind.Local).AddTicks(28), new DateTime(2025, 11, 27, 13, 49, 44, 671, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 49, 44, 671, DateTimeKind.Local).AddTicks(35), new DateTime(2025, 11, 27, 13, 49, 44, 671, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 49, 44, 671, DateTimeKind.Local).AddTicks(39), new DateTime(2025, 11, 27, 13, 49, 44, 671, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 49, 44, 671, DateTimeKind.Local).AddTicks(45), new DateTime(2025, 11, 27, 13, 49, 44, 671, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5269), new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5292), new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5729), new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5734), new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5959), new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5964), new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5968), new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5971), new DateTime(2025, 11, 27, 13, 28, 31, 235, DateTimeKind.Local).AddTicks(5972) });
        }
    }
}
