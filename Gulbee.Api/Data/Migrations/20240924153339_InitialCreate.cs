using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gulbee.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutritions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fat = table.Column<double>(type: "REAL", nullable: false),
                    Carbo = table.Column<double>(type: "REAL", nullable: false),
                    Sugar = table.Column<double>(type: "REAL", nullable: false),
                    Proteins = table.Column<double>(type: "REAL", nullable: false),
                    Salt = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Kcal = table.Column<int>(type: "INTEGER", nullable: false),
                    NutriId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Nutritions_NutriId",
                        column: x => x.NutriId,
                        principalTable: "Nutritions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Owoc" });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "Id", "Carbo", "Fat", "Proteins", "Salt", "Sugar" },
                values: new object[,]
                {
                    { 1, 10.0, 3.0, 5.0, 0.0, 2.0 },
                    { 2, 10.0, 3.0, 5.0, 0.0, 2.0 },
                    { 3, 10.0, 3.0, 5.0, 0.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Kcal", "Name", "NutriId" },
                values: new object[,]
                {
                    { 1, 1, 40, "Banan", 1 },
                    { 2, 1, 40, "Jabłko", 2 },
                    { 3, 1, 40, "Truskawka", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_NutriId",
                table: "Products",
                column: "NutriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Nutritions");
        }
    }
}
