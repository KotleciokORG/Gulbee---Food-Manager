using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gulbee.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChatGPTData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "Id", "Carbo", "Fat", "Fiber", "Proteins", "Salt", "Sugar" },
                values: new object[,]
                {
                    { 1, 22.84, 0.33000000000000002, 2.0, 1.0900000000000001, 0.0, 12.23 },
                    { 2, 1.28, 33.140000000000001, 0.0, 24.899999999999999, 1.8, 0.5 },
                    { 3, 9.5800000000000001, 0.23999999999999999, 1.5, 0.93000000000000005, 0.0, 4.7400000000000002 },
                    { 4, 0.0, 13.6, 0.0, 27.300000000000001, 0.10000000000000001, 0.0 },
                    { 5, 43.299999999999997, 4.2000000000000002, 5.0, 8.8000000000000007, 0.5, 6.0 },
                    { 6, 30.0, 15.0, 2.0, 17.0, 1.0, 5.0 },
                    { 7, 0.0, 100.0, 0.0, 0.0, 0.0, 0.0 },
                    { 8, 44.0, 6.0, 1.0, 5.0, 1.5, 2.0 },
                    { 9, 13.81, 0.17000000000000001, 0.80000000000000004, 0.26000000000000001, 0.0, 10.390000000000001 },
                    { 10, 3.6000000000000001, 3.2999999999999998, 0.5, 10.0, 0.10000000000000001, 4.7000000000000002 },
                    { 11, 15.23, 0.14000000000000001, 0.69999999999999996, 0.35999999999999999, 0.0, 9.75 },
                    { 12, 3.3799999999999999, 4.2999999999999998, 1.2, 11.119999999999999, 0.59999999999999998, 2.7000000000000002 },
                    { 13, 3.9199999999999999, 0.20000000000000001, 1.0, 0.88, 0.0, 2.6299999999999999 },
                    { 14, 0.0, 15.0, 0.0, 26.0, 0.10000000000000001, 0.0 },
                    { 15, 30.449999999999999, 1.5, 2.2999999999999998, 6.0, 0.10000000000000001, 1.1000000000000001 },
                    { 16, 33.329999999999998, 10.0, 4.0, 11.0, 1.0, 3.0 },
                    { 17, 0.0, 100.0, 0.0, 0.0, 0.0, 0.0 },
                    { 18, 39.0, 3.0, 3.5, 6.0, 1.5, 2.0 },
                    { 19, 11.94, 0.65000000000000002, 1.6000000000000001, 1.2, 0.0, 4.4199999999999999 },
                    { 20, 3.3999999999999999, 0.29999999999999999, 1.0, 16.0, 0.5, 2.7000000000000002 },
                    { 21, 6.0300000000000002, 0.29999999999999999, 0.59999999999999998, 1.0, 0.0, 4.2000000000000002 },
                    { 22, 1.5, 5.5, 1.1000000000000001, 20.0, 1.5, 1.0 },
                    { 23, 71.5, 3.1000000000000001, 5.2000000000000002, 13.300000000000001, 0.10000000000000001, 0.90000000000000002 },
                    { 24, 41.399999999999999, 15.0, 2.5, 3.3999999999999999, 1.3, 0.40000000000000002 },
                    { 25, 0.0, 100.0, 0.0, 0.0, 0.0, 0.0 },
                    { 26, 30.0, 12.0, 1.8999999999999999, 15.0, 1.8, 3.5 },
                    { 27, 7.6799999999999997, 0.29999999999999999, 1.2, 0.67000000000000004, 0.0, 4.8899999999999997 },
                    { 28, 4.9900000000000002, 0.97999999999999998, 0.40000000000000002, 3.3999999999999999, 0.10000000000000001, 5.0 },
                    { 29, 2.1600000000000001, 0.16, 0.29999999999999999, 0.65000000000000002, 0.0, 1.3799999999999999 },
                    { 30, 1.4299999999999999, 42.0, 0.0, 37.0, 1.8, 0.45000000000000001 },
                    { 31, 14.07, 0.33000000000000002, 1.5, 0.81000000000000005, 0.0, 10.02 },
                    { 32, 1.7, 7.0, 0.0, 20.0, 1.7, 0.5 },
                    { 33, 72.569999999999993, 1.8700000000000001, 3.0, 10.67, 0.01, 1.1200000000000001 },
                    { 34, 36.0, 17.0, 2.3999999999999999, 10.0, 1.5, 1.8 },
                    { 35, 0.0, 100.0, 0.0, 0.0, 0.0, 0.0 },
                    { 36, 28.0, 10.0, 2.0, 16.0, 2.0, 3.0 },
                    { 37, 4.8099999999999996, 0.12, 1.2, 0.88, 0.0, 4.7400000000000002 },
                    { 38, 9.6300000000000008, 0.60999999999999999, 0.80000000000000004, 1.1499999999999999, 0.0, 5.4100000000000001 },
                    { 39, 10.449999999999999, 0.12, 1.6000000000000001, 0.91000000000000003, 0.01, 9.0999999999999996 },
                    { 40, 2.0, 48.0, 0.0, 30.0, 2.5, 0.69999999999999996 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Kcal", "Name", "NutriId" },
                values: new object[,]
                {
                    { 1, 1, 89, "Banan", 1 },
                    { 2, 2, 402, "Ser Cheddar", 2 },
                    { 3, 3, 41, "Marchew", 3 },
                    { 4, 4, 239, "Kurczak", 4 },
                    { 5, 5, 246, "Chleb pełnoziarnisty", 5 },
                    { 6, 6, 295, "Burger", 6 },
                    { 7, 7, 884, "Oliwa z oliwek", 7 },
                    { 8, 8, 240, "Zupa instant", 8 },
                    { 9, 1, 52, "Jabłko", 9 },
                    { 10, 2, 59, "Jogurt naturalny", 10 },
                    { 11, 1, 57, "Gruszka", 11 },
                    { 12, 2, 98, "Serek wiejski", 12 },
                    { 13, 3, 18, "Pomidor", 13 },
                    { 14, 4, 250, "Wołowina", 14 },
                    { 15, 5, 157, "Makaron pełnoziarnisty", 15 },
                    { 16, 6, 266, "Pizza", 16 },
                    { 17, 7, 862, "Olej kokosowy", 17 },
                    { 18, 8, 210, "Gotowe pierogi", 18 },
                    { 19, 1, 52, "Malina", 19 },
                    { 20, 2, 72, "Twaróg chudy", 20 },
                    { 21, 3, 31, "Papryka", 21 },
                    { 22, 4, 145, "Szynka", 22 },
                    { 23, 5, 343, "Kasza gryczana", 23 },
                    { 24, 6, 312, "Frytki", 24 },
                    { 25, 7, 884, "Olej rzepakowy", 25 },
                    { 26, 8, 300, "Gotowa lasagna", 26 },
                    { 27, 1, 32, "Truskawka", 27 },
                    { 28, 2, 42, "Mleko", 28 },
                    { 29, 3, 12, "Ogórek", 29 },
                    { 30, 4, 541, "Boczek", 30 },
                    { 31, 1, 60, "Brzoskwinia", 31 },
                    { 32, 2, 65, "Kefir", 32 },
                    { 33, 5, 360, "Ryż brązowy", 33 },
                    { 34, 6, 295, "Hamburger", 34 },
                    { 35, 7, 884, "Olej lniany", 35 },
                    { 36, 8, 260, "Gotowa pizza", 36 },
                    { 37, 1, 50, "Czereśnia", 37 },
                    { 38, 2, 61, "Jogurt naturalny", 38 },
                    { 39, 1, 47, "Pomarańcza", 39 },
                    { 40, 4, 500, "Kabanos", 40 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
