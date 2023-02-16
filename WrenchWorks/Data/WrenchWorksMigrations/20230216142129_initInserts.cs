using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WrenchWorks.Data.WrenchWorksMigrations
{
    /// <inheritdoc />
    public partial class initInserts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "bodyColors",
                column: "bodyColor",
                values: new object[]
                {
                    "Beige",
                    "Black",
                    "Blue",
                    "Bronze",
                    "Brown",
                    "CUSTOM",
                    "Gold",
                    "Gray",
                    "Green",
                    "Orange",
                    "Pink",
                    "Purple",
                    "Red",
                    "Silver",
                    "White",
                    "Yellow"
                });

            migrationBuilder.InsertData(
                table: "fuelTypes",
                column: "fuelType",
                values: new object[]
                {
                    "Diesel",
                    "Electric",
                    "Hydrogen",
                    "Nuclear",
                    "Petrol"
                });

            migrationBuilder.InsertData(
                table: "positions",
                columns: new[] { "positionID", "positionName", "supervisorID" },
                values: new object[,]
                {
                    { (short)0, "Owner", null },
                    { (short)1, "Quality Engineer", (short)0 },
                    { (short)2, "Parts Manager", (short)0 },
                    { (short)3, "Workshop Manager", (short)0 },
                    { (short)4, "Diagonostic Specialist", (short)3 },
                    { (short)5, "Quality Specialist", (short)1 },
                    { (short)6, "Automotive Specialist", (short)3 },
                    { (short)9, "Trainee", (short)3 },
                    { (short)7, "Assistant Diagonostic Specialist", (short)4 },
                    { (short)8, "Assistant Automotive Specialist", (short)6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Beige");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Black");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Blue");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Bronze");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Brown");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "CUSTOM");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Gold");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Gray");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Green");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Orange");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Pink");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Purple");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Red");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Silver");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "White");

            migrationBuilder.DeleteData(
                table: "bodyColors",
                keyColumn: "bodyColor",
                keyValue: "Yellow");

            migrationBuilder.DeleteData(
                table: "fuelTypes",
                keyColumn: "fuelType",
                keyValue: "Diesel");

            migrationBuilder.DeleteData(
                table: "fuelTypes",
                keyColumn: "fuelType",
                keyValue: "Electric");

            migrationBuilder.DeleteData(
                table: "fuelTypes",
                keyColumn: "fuelType",
                keyValue: "Hydrogen");

            migrationBuilder.DeleteData(
                table: "fuelTypes",
                keyColumn: "fuelType",
                keyValue: "Nuclear");

            migrationBuilder.DeleteData(
                table: "fuelTypes",
                keyColumn: "fuelType",
                keyValue: "Petrol");

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)7);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)8);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)9);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)6);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "positions",
                keyColumn: "positionID",
                keyValue: (short)0);
        }
    }
}
