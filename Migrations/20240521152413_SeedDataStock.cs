using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test_shopping_cart.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StockInven",
                columns: new[] { "Id", "Amount", "CreatedDate", "IsAction", "ProductId", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("11cb271e-69bf-4653-ab83-42c42bbc84bc"), 10, new DateTime(2024, 5, 21, 22, 24, 13, 504, DateTimeKind.Local).AddTicks(9631), true, new Guid("3c9af691-60eb-4f38-b2c5-d627fc1eaba0"), 10.0 },
                    { new Guid("1dd8677a-8d3f-42b6-926c-91b256cdd81b"), 11, new DateTime(2024, 5, 21, 22, 24, 13, 504, DateTimeKind.Local).AddTicks(9659), true, new Guid("7aacf121-55cd-45ea-afa7-b368b42dbddc"), 125.0 },
                    { new Guid("2945be21-f977-4a4d-afb1-8854547badd3"), 5, new DateTime(2024, 5, 21, 22, 24, 13, 504, DateTimeKind.Local).AddTicks(9646), true, new Guid("ebd02b56-51bf-4b5b-9021-5365b15bd137"), 15.0 },
                    { new Guid("36f73ea1-019c-4ca1-862c-1a924d1c7000"), 9, new DateTime(2024, 5, 21, 22, 24, 13, 504, DateTimeKind.Local).AddTicks(9661), true, new Guid("48cd0b38-108f-405f-835a-d0deba24a2c6"), 89.0 },
                    { new Guid("98df7a4f-7c1e-41ce-b82c-5af4c6b7b39a"), 6, new DateTime(2024, 5, 21, 22, 24, 13, 504, DateTimeKind.Local).AddTicks(9649), true, new Guid("a40a3223-40b1-47eb-a762-fca7a0ec7566"), 8.0 },
                    { new Guid("9ab44d23-6e99-4751-8393-c945f59d1f66"), 20, new DateTime(2024, 5, 21, 22, 24, 13, 504, DateTimeKind.Local).AddTicks(9656), true, new Guid("62351332-8db4-4930-b219-a6af900efb7e"), 25.0 },
                    { new Guid("aec23aaf-6a1b-4254-b81e-4f826b1f2baa"), 10, new DateTime(2024, 5, 21, 22, 24, 13, 504, DateTimeKind.Local).AddTicks(9652), true, new Guid("f4c3fd26-f750-43f5-86b0-25f38408a9a3"), 12.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StockInven",
                keyColumn: "Id",
                keyValue: new Guid("11cb271e-69bf-4653-ab83-42c42bbc84bc"));

            migrationBuilder.DeleteData(
                table: "StockInven",
                keyColumn: "Id",
                keyValue: new Guid("1dd8677a-8d3f-42b6-926c-91b256cdd81b"));

            migrationBuilder.DeleteData(
                table: "StockInven",
                keyColumn: "Id",
                keyValue: new Guid("2945be21-f977-4a4d-afb1-8854547badd3"));

            migrationBuilder.DeleteData(
                table: "StockInven",
                keyColumn: "Id",
                keyValue: new Guid("36f73ea1-019c-4ca1-862c-1a924d1c7000"));

            migrationBuilder.DeleteData(
                table: "StockInven",
                keyColumn: "Id",
                keyValue: new Guid("98df7a4f-7c1e-41ce-b82c-5af4c6b7b39a"));

            migrationBuilder.DeleteData(
                table: "StockInven",
                keyColumn: "Id",
                keyValue: new Guid("9ab44d23-6e99-4751-8393-c945f59d1f66"));

            migrationBuilder.DeleteData(
                table: "StockInven",
                keyColumn: "Id",
                keyValue: new Guid("aec23aaf-6a1b-4254-b81e-4f826b1f2baa"));
        }
    }
}
