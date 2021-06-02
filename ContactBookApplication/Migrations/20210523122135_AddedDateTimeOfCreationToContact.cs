using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactBookApplication.Migrations
{
    public partial class AddedDateTimeOfCreationToContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "10670392-8a13-4718-9188-93b1766c852b");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "39356a1d-8a05-4cd2-b261-e296afa3d1d3");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "a52f3127-11ca-4434-bd37-2b728af0e0be");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "c985a18c-9215-4a99-824f-2caa9e9954b4");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "e583f61e-e718-4566-9684-2a177094871f");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "f7b1eb43-3a98-4dcb-9a56-48517d21e1a3");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Contacts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 23, 12, 21, 35, 84, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 23, 12, 21, 35, 84, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 23, 12, 21, 35, 84, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "DateOfCreation",
                value: new DateTime(2021, 5, 23, 12, 21, 35, 82, DateTimeKind.Utc).AddTicks(7562));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "DateOfCreation",
                table: "Contacts");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "c985a18c-9215-4a99-824f-2caa9e9954b4", "Aja", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", null, "Lagos", "Asajon", "7" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "10670392-8a13-4718-9188-93b1766c852b", "Mubi", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", "1233234", "Adamawa", "Adsu Staff Quaters", "36" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "39356a1d-8a05-4cd2-b261-e296afa3d1d3", "Jalingo", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "Nigeria", "56342", "Taraba", "Goverment House", "16" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "a52f3127-11ca-4434-bd37-2b728af0e0be", "Queens", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "32344", "New York", "South side", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "e583f61e-e718-4566-9684-2a177094871f", "Beverly Hills", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "34231", "Carlifonia", "Angels", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "f7b1eb43-3a98-4dcb-9a56-48517d21e1a3", "Owerri Municipal", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Nigeria", "34231", "Imo", "Okigwe", "5" });
        }
    }
}
