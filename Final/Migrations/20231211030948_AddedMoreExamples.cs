using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    public partial class AddedMoreExamples : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[,]
                {
                    { 3, "Company 3" },
                    { 4, "Company 4" },
                    { 5, "Company 5" },
                    { 6, "Company 6" },
                    { 7, "Company 7" },
                    { 8, "Company 8" },
                    { 9, "Company 9" },
                    { 10, "Company 10" }
                });

            migrationBuilder.InsertData(
                table: "Contries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { 3, "Country 3" },
                    { 4, "Country 4" },
                    { 5, "Country 5" },
                    { 6, "Country 6" },
                    { 7, "Country 7" },
                    { 8, "Country 8" },
                    { 9, "Country 9" },
                    { 10, "Country 10" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CompanyId", "ContactName", "CountryId" },
                values: new object[,]
                {
                    { 3, 3, "Contact 3", 3 },
                    { 4, 4, "Contact 4", 4 },
                    { 5, 5, "Contact 5", 5 },
                    { 6, 6, "Contact 6", 6 },
                    { 7, 7, "Contact 7", 7 },
                    { 8, 8, "Contact 8", 8 },
                    { 9, 9, "Contact 9", 9 },
                    { 10, 10, "Contact 10", 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "CountryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "CountryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "CountryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "CountryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "CountryId",
                keyValue: 10);
        }
    }
}
