using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactBookApplication.Migrations
{
    public partial class AddedPhotoToContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "111c1a8a-a7a8-4b6f-8c89-6d22021d05d9");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "c2d62492-1422-4c96-b0d2-db1eaa198253");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "c603a05c-7479-41ea-b57f-851c0787dea2");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "d7509484-f2cf-4af9-8923-624584f8f003");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "e674705e-7348-4a8c-8f9d-bd9e88c306ac");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "f8ed45ad-2647-41da-8021-e30b39c02b4c");

            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ContactId = table.Column<Guid>(type: "TEXT", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Firstname");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Contacts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "e674705e-7348-4a8c-8f9d-bd9e88c306ac", "Aja", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", null, "Lagos", "Asajon", "7" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "c603a05c-7479-41ea-b57f-851c0787dea2", "Mubi", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", "1233234", "Adamawa", "Adsu Staff Quaters", "36" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "f8ed45ad-2647-41da-8021-e30b39c02b4c", "Jalingo", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "Nigeria", "56342", "Taraba", "Goverment House", "16" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "c2d62492-1422-4c96-b0d2-db1eaa198253", "Queens", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "32344", "New York", "South side", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "111c1a8a-a7a8-4b6f-8c89-6d22021d05d9", "Beverly Hills", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "34231", "Carlifonia", "Angels", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "d7509484-f2cf-4af9-8923-624584f8f003", "Owerri Municipal", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Nigeria", "34231", "Imo", "Okigwe", "5" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                columns: new[] { "DateOfCreation", "PictureUrl" },
                values: new object[] { new DateTime(2021, 5, 23, 12, 21, 35, 84, DateTimeKind.Utc).AddTicks(903), "ugee.jpg" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                columns: new[] { "DateOfCreation", "PictureUrl" },
                values: new object[] { new DateTime(2021, 5, 23, 12, 21, 35, 84, DateTimeKind.Utc).AddTicks(627), "solomon.jpg" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                columns: new[] { "DateOfCreation", "PictureUrl" },
                values: new object[] { new DateTime(2021, 5, 23, 12, 21, 35, 84, DateTimeKind.Utc).AddTicks(1587), "ugee.jpg" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                columns: new[] { "DateOfCreation", "PictureUrl" },
                values: new object[] { new DateTime(2021, 5, 23, 12, 21, 35, 82, DateTimeKind.Utc).AddTicks(7562), "victor.jpg" });
        }
    }
}
