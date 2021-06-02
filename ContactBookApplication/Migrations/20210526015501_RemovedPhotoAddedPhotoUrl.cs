using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactBookApplication.Migrations
{
    public partial class RemovedPhotoAddedPhotoUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "286cabbc-cd20-4e08-aa09-8532a2b9f381");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "5de9dc97-7d04-4f83-b5d7-94e8d60d4f57");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "69018a0a-ed0e-4cda-b699-bc692eb6dcad");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "888b6b46-6044-43e0-9772-eced1ca3f460");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "f0756a26-187a-4193-ad6f-d6cf50d2c819");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "f551178e-4f5c-4101-8416-871af711d1e8");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Contacts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "0d0f39b9-e3f5-432a-a0cb-80b6d7bd1d25", "Aja", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", null, "Lagos", "Asajon", "7" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "24116003-cb87-4f52-b1a5-9089d9a1e6a2", "Mubi", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", "1233234", "Adamawa", "Adsu Staff Quaters", "36" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "5cc710e1-dee4-40bd-ba5d-2fda37b1b92e", "Jalingo", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "Nigeria", "56342", "Taraba", "Goverment House", "16" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "14e5b40f-f4ad-47b3-9f14-370dcc978e53", "Queens", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "32344", "New York", "South side", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "7cacf50d-bc14-46f3-9f90-c80c5a3c4398", "Beverly Hills", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "34231", "Carlifonia", "Angels", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "c0d7bda4-80cd-47f9-8887-2f8f38fe523e", "Owerri Municipal", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Nigeria", "34231", "Imo", "Okigwe", "5" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 26, 1, 55, 1, 97, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 26, 1, 55, 1, 97, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 26, 1, 55, 1, 97, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 26, 1, 55, 1, 96, DateTimeKind.Utc).AddTicks(542));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "0d0f39b9-e3f5-432a-a0cb-80b6d7bd1d25");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "14e5b40f-f4ad-47b3-9f14-370dcc978e53");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "24116003-cb87-4f52-b1a5-9089d9a1e6a2");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "5cc710e1-dee4-40bd-ba5d-2fda37b1b92e");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "7cacf50d-bc14-46f3-9f90-c80c5a3c4398");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "c0d7bda4-80cd-47f9-8887-2f8f38fe523e");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Contacts");

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContactId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "69018a0a-ed0e-4cda-b699-bc692eb6dcad", "Aja", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", null, "Lagos", "Asajon", "7" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "f0756a26-187a-4193-ad6f-d6cf50d2c819", "Mubi", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", "1233234", "Adamawa", "Adsu Staff Quaters", "36" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "286cabbc-cd20-4e08-aa09-8532a2b9f381", "Jalingo", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "Nigeria", "56342", "Taraba", "Goverment House", "16" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "5de9dc97-7d04-4f83-b5d7-94e8d60d4f57", "Queens", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "32344", "New York", "South side", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "f551178e-4f5c-4101-8416-871af711d1e8", "Beverly Hills", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "34231", "Carlifonia", "Angels", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "888b6b46-6044-43e0-9772-eced1ca3f460", "Owerri Municipal", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Nigeria", "34231", "Imo", "Okigwe", "5" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 26, 0, 47, 4, 837, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 26, 0, 47, 4, 837, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 26, 0, 47, 4, 838, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 26, 0, 47, 4, 836, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ContactId",
                table: "Photos",
                column: "ContactId",
                unique: true);
        }
    }
}
