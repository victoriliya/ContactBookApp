﻿// <auto-generated />
using System;
using ContactBookApplication.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactBookApplication.Migrations
{
    [DbContext(typeof(ContactBookContext))]
    [Migration("20210526004705_AddedPhotoToContact")]
    partial class AddedPhotoToContact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("ContactBookApplication.Entities.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostCode")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetName")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetNumber")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = "69018a0a-ed0e-4cda-b699-bc692eb6dcad",
                            City = "Aja",
                            ContactId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Country = "Nigeria",
                            State = "Lagos",
                            StreetName = "Asajon",
                            StreetNumber = "7"
                        },
                        new
                        {
                            Id = "f0756a26-187a-4193-ad6f-d6cf50d2c819",
                            City = "Mubi",
                            ContactId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Country = "Nigeria",
                            PostCode = "1233234",
                            State = "Adamawa",
                            StreetName = "Adsu Staff Quaters",
                            StreetNumber = "36"
                        },
                        new
                        {
                            Id = "286cabbc-cd20-4e08-aa09-8532a2b9f381",
                            City = "Jalingo",
                            ContactId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Country = "Nigeria",
                            PostCode = "56342",
                            State = "Taraba",
                            StreetName = "Goverment House",
                            StreetNumber = "16"
                        },
                        new
                        {
                            Id = "5de9dc97-7d04-4f83-b5d7-94e8d60d4f57",
                            City = "Queens",
                            ContactId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Country = "USA",
                            PostCode = "32344",
                            State = "New York",
                            StreetName = "South side",
                            StreetNumber = "5"
                        },
                        new
                        {
                            Id = "f551178e-4f5c-4101-8416-871af711d1e8",
                            City = "Beverly Hills",
                            ContactId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Country = "USA",
                            PostCode = "34231",
                            State = "Carlifonia",
                            StreetName = "Angels",
                            StreetNumber = "5"
                        },
                        new
                        {
                            Id = "888b6b46-6044-43e0-9772-eced1ca3f460",
                            City = "Owerri Municipal",
                            ContactId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Country = "Nigeria",
                            PostCode = "34231",
                            State = "Imo",
                            StreetName = "Okigwe",
                            StreetNumber = "5"
                        });
                });

            modelBuilder.Entity("ContactBookApplication.Entities.Contact", b =>
                {
                    b.Property<Guid>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyEmail")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("NickName")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Salutation")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Company = "decagon",
                            CompanyEmail = "victor.iliya@decagon.com",
                            DateOfCreation = new DateTime(2021, 5, 26, 0, 47, 4, 836, DateTimeKind.Utc).AddTicks(1450),
                            FirstName = "Victor",
                            OtherName = "B",
                            Salutation = "Mr.",
                            SecondName = "Iliya",
                            Website = "hhtps://victoriliya.com"
                        },
                        new
                        {
                            ContactId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Company = "decagon",
                            CompanyEmail = "young@decagon.com",
                            DateOfCreation = new DateTime(2021, 5, 26, 0, 47, 4, 837, DateTimeKind.Utc).AddTicks(9833),
                            FirstName = "Solomon",
                            OtherName = "",
                            Salutation = "Mr.",
                            SecondName = "Young",
                            Website = "hhtps://young.com"
                        },
                        new
                        {
                            ContactId = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            Company = "Roc Nation",
                            CompanyEmail = "jigga@rocnation.com",
                            DateOfCreation = new DateTime(2021, 5, 26, 0, 47, 4, 837, DateTimeKind.Utc).AddTicks(9959),
                            FirstName = "Shawn",
                            NickName = "Jay-Z",
                            OtherName = "",
                            Salutation = "Mr.",
                            SecondName = "Carter",
                            Website = "hhtps://ugee.com"
                        },
                        new
                        {
                            ContactId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Company = "decagon",
                            CompanyEmail = "ugee@decagon.com",
                            DateOfCreation = new DateTime(2021, 5, 26, 0, 47, 4, 838, DateTimeKind.Utc).AddTicks(1343),
                            FirstName = "Ugee",
                            OtherName = "",
                            Salutation = "Mr.",
                            SecondName = "Umeoke",
                            Website = "hhtps://ugee.com"
                        });
                });

            modelBuilder.Entity("ContactBookApplication.Entities.EmailAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Email = "victorbiliya@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            ContactId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Email = "vick@gmail.com"
                        },
                        new
                        {
                            Id = 3,
                            ContactId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Email = "ugee@gmail.com"
                        },
                        new
                        {
                            Id = 4,
                            ContactId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Email = "young@gmail.com"
                        },
                        new
                        {
                            Id = 5,
                            ContactId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Email = "hov@gmail.com"
                        });
                });

            modelBuilder.Entity("ContactBookApplication.Entities.PhoneNumber", b =>
                {
                    b.Property<int>("PhoneNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.HasKey("PhoneNumberId");

                    b.HasIndex("ContactId");

                    b.ToTable("PhoneNumbers");

                    b.HasData(
                        new
                        {
                            PhoneNumberId = 1,
                            ContactId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            CountryCode = "234",
                            Number = "7034192342"
                        },
                        new
                        {
                            PhoneNumberId = 2,
                            ContactId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            CountryCode = "234",
                            Number = "813344567"
                        },
                        new
                        {
                            PhoneNumberId = 3,
                            ContactId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            CountryCode = "234",
                            Number = "9032456783"
                        },
                        new
                        {
                            PhoneNumberId = 4,
                            ContactId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            CountryCode = "234",
                            Number = "9133456432"
                        },
                        new
                        {
                            PhoneNumberId = 6,
                            ContactId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            CountryCode = "234",
                            Number = "8063445467"
                        },
                        new
                        {
                            PhoneNumberId = 7,
                            ContactId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            CountryCode = "1",
                            Number = "5352323433"
                        });
                });

            modelBuilder.Entity("ContactBookApplication.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("ContactBookApplication.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecondName")
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ContactBookApplication.Entities.Address", b =>
                {
                    b.HasOne("ContactBookApplication.Entities.Contact", "Contact")
                        .WithMany("Addresses")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("ContactBookApplication.Entities.EmailAddress", b =>
                {
                    b.HasOne("ContactBookApplication.Entities.Contact", null)
                        .WithMany("Emails")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContactBookApplication.Entities.PhoneNumber", b =>
                {
                    b.HasOne("ContactBookApplication.Entities.Contact", null)
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContactBookApplication.Entities.Photo", b =>
                {
                    b.HasOne("ContactBookApplication.Entities.Contact", "Contact")
                        .WithOne("Photo")
                        .HasForeignKey("ContactBookApplication.Entities.Photo", "ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ContactBookApplication.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ContactBookApplication.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContactBookApplication.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ContactBookApplication.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContactBookApplication.Entities.Contact", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Emails");

                    b.Navigation("PhoneNumbers");

                    b.Navigation("Photo");
                });
#pragma warning restore 612, 618
        }
    }
}
