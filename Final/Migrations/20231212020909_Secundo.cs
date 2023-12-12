using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    public partial class Secundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Contries_CountryId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contries",
                table: "Contries");

            migrationBuilder.RenameTable(
                name: "Contries",
                newName: "Countries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Countries_CountryId",
                table: "Contacts",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Countries_CountryId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Contries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contries",
                table: "Contries",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Contries_CountryId",
                table: "Contacts",
                column: "CountryId",
                principalTable: "Contries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
