using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test_shopping_cart.Migrations
{
    /// <inheritdoc />
    public partial class InitDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SkuCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SkuName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CostPrice = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StockInven",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "double", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsAction = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ProductId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInven", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockInven_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CostPrice", "SkuCode", "SkuName" },
                values: new object[,]
                {
                    { new Guid("3c9af691-60eb-4f38-b2c5-d627fc1eaba0"), 4.5, "S-00001", "ดินสอ" },
                    { new Guid("48cd0b38-108f-405f-835a-d0deba24a2c6"), 40.0, "S-00007", "แม็กเย็บกระดาษ เบอร์ 35" },
                    { new Guid("62351332-8db4-4930-b219-a6af900efb7e"), 12.5, "S-00005", "น้ํายาลบคําผิด" },
                    { new Guid("7aacf121-55cd-45ea-afa7-b368b42dbddc"), 70.0, "S-00006", "กระดาษ a4 80 แกรม(500แผ่น)" },
                    { new Guid("a40a3223-40b1-47eb-a762-fca7a0ec7566"), 3.0, "S-00003", "ยางลบ" },
                    { new Guid("ebd02b56-51bf-4b5b-9021-5365b15bd137"), 7.0, "S-00002", "ปากกา" },
                    { new Guid("f4c3fd26-f750-43f5-86b0-25f38408a9a3"), 6.0, "S-00004", "ไม้บรรทัด" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockInven_ProductId",
                table: "StockInven",
                column: "ProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockInven");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
