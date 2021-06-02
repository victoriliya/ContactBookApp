using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactBookApplication.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Firstname = table.Column<string>(type: "TEXT", nullable: true),
                    SecondName = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Salutation = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    SecondName = table.Column<string>(type: "TEXT", nullable: true),
                    OtherName = table.Column<string>(type: "TEXT", nullable: true),
                    NickName = table.Column<string>(type: "TEXT", nullable: true),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Website = table.Column<string>(type: "TEXT", nullable: true),
                    Company = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyEmail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    StreetName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    StreetNumber = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    PostCode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ContactId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    ContactId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryCode = table.Column<string>(type: "TEXT", nullable: true),
                    Number = table.Column<string>(type: "TEXT", nullable: true),
                    ContactId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Company", "CompanyEmail", "FirstName", "NickName", "OtherName", "PictureUrl", "Salutation", "SecondName", "Website" },
                values: new object[] { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "decagon", "victor.iliya@decagon.com", "Victor", null, "B", "victor.jpg", "Mr.", "Iliya", "hhtps://victoriliya.com" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Company", "CompanyEmail", "FirstName", "NickName", "OtherName", "PictureUrl", "Salutation", "SecondName", "Website" },
                values: new object[] { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "decagon", "young@decagon.com", "Solomon", null, "", "solomon.jpg", "Mr.", "Young", "hhtps://young.com" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Company", "CompanyEmail", "FirstName", "NickName", "OtherName", "PictureUrl", "Salutation", "SecondName", "Website" },
                values: new object[] { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), "Roc Nation", "jigga@rocnation.com", "Shawn", "Jay-Z", "", "ugee.jpg", "Mr.", "Carter", "hhtps://ugee.com" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Company", "CompanyEmail", "FirstName", "NickName", "OtherName", "PictureUrl", "Salutation", "SecondName", "Website" },
                values: new object[] { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "decagon", "ugee@decagon.com", "Ugee", null, "", "ugee.jpg", "Mr.", "Umeoke", "hhtps://ugee.com" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "c985a18c-9215-4a99-824f-2caa9e9954b4", "Aja", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", null, "Lagos", "Asajon", "7" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "f7b1eb43-3a98-4dcb-9a56-48517d21e1a3", "Owerri Municipal", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Nigeria", "34231", "Imo", "Okigwe", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "a52f3127-11ca-4434-bd37-2b728af0e0be", "Queens", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "32344", "New York", "South side", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "39356a1d-8a05-4cd2-b261-e296afa3d1d3", "Jalingo", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "Nigeria", "56342", "Taraba", "Goverment House", "16" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "e583f61e-e718-4566-9684-2a177094871f", "Beverly Hills", new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "USA", "34231", "Carlifonia", "Angels", "5" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "ContactId", "Country", "PostCode", "State", "StreetName", "StreetNumber" },
                values: new object[] { "10670392-8a13-4718-9188-93b1766c852b", "Mubi", new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Nigeria", "1233234", "Adamawa", "Adsu Staff Quaters", "36" });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "ContactId", "Email" },
                values: new object[] { 2, new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "vick@gmail.com" });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "ContactId", "Email" },
                values: new object[] { 1, new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "victorbiliya@gmail.com" });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "ContactId", "Email" },
                values: new object[] { 4, new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "young@gmail.com" });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "ContactId", "Email" },
                values: new object[] { 5, new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "hov@gmail.com" });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "ContactId", "Email" },
                values: new object[] { 3, new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "ugee@gmail.com" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "ContactId", "CountryCode", "Number" },
                values: new object[] { 2, new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "234", "813344567" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "ContactId", "CountryCode", "Number" },
                values: new object[] { 3, new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "234", "9032456783" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "ContactId", "CountryCode", "Number" },
                values: new object[] { 6, new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "234", "8063445467" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "ContactId", "CountryCode", "Number" },
                values: new object[] { 7, new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), "1", "5352323433" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "ContactId", "CountryCode", "Number" },
                values: new object[] { 1, new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "234", "7034192342" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "ContactId", "CountryCode", "Number" },
                values: new object[] { 4, new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "234", "9133456432" });

            migrationBuilder.CreateIndex(
                name: "IX_Address_ContactId",
                table: "Address",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ContactId",
                table: "Emails",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_ContactId",
                table: "PhoneNumbers",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
