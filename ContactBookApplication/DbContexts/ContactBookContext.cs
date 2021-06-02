using ContactBookApplication.Entities;
using ContactBookApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.DbContexts
{
    public class ContactBookContext : IdentityDbContext<User>
    {
        public ContactBookContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<EmailAddress> Emails{get; set;}
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Seed contact
            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                Salutation = "Mr.",
                FirstName = "Victor",
                SecondName = "Iliya",
                OtherName = "B",
                Website = "hhtps://victoriliya.com",
                Company = "decagon",
                CompanyEmail = "victor.iliya@decagon.com"
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                Salutation = "Mr.",
                FirstName = "Solomon",
                SecondName = "Young",
                OtherName = "",
                Website = "hhtps://young.com",
                Company = "decagon",
                CompanyEmail = "young@decagon.com"
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                Salutation = "Mr.",
                FirstName = "Shawn",
                SecondName = "Carter",
                OtherName = "",
                NickName = "Jay-Z",
                Website = "hhtps://ugee.com",
                Company = "Roc Nation",
                CompanyEmail = "jigga@rocnation.com"
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                Salutation = "Mr.",
                FirstName = "Ugee",
                SecondName = "Umeoke",
                OtherName = "",
                Website = "hhtps://ugee.com",
                Company = "decagon",
                CompanyEmail = "ugee@decagon.com"
            });

            modelBuilder.Entity<Address>().HasData(new Address
            {
                StreetNumber = "7",
                StreetName = "Asajon",
                City = "Aja",
                State = "Lagos",
                Country = "Nigeria",
                ContactId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee")

            });

            modelBuilder.Entity<Address>().HasData(new Address
            {
                StreetNumber = "36",
                StreetName = "Adsu Staff Quaters",
                City = "Mubi",
                State = "Adamawa",
                PostCode = "1233234",
                Country = "Nigeria",
                ContactId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee")

            });

            modelBuilder.Entity<Address>().HasData(new Address
            {
                StreetNumber = "16",
                StreetName = "Goverment House",
                City = "Jalingo",
                State = "Taraba",
                PostCode = "56342",
                Country = "Nigeria",
                ContactId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97")

            });

            modelBuilder.Entity<Address>().HasData(new Address
            {
                StreetNumber = "5",
                StreetName = "South side",
                City = "Queens",
                State = "New York",
                PostCode = "32344",
                Country = "USA",
                ContactId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97")

            });

            modelBuilder.Entity<Address>().HasData(new Address
            {
                StreetNumber = "5",
                StreetName = "Angels",
                City = "Beverly Hills",
                State = "Carlifonia",
                PostCode = "34231",
                Country = "USA",
                ContactId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97")

            });

            modelBuilder.Entity<Address>().HasData(new Address
            {
                StreetNumber = "5",
                StreetName = "Okigwe",
                City = "Owerri Municipal",
                State = "Imo",
                PostCode = "34231",
                Country = "Nigeria",
                ContactId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")

            });

            modelBuilder.Entity<EmailAddress>().HasData(new EmailAddress
            {
                Id = 1,
                Email = "victorbiliya@gmail.com",
                ContactId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee")

            });

            modelBuilder.Entity<EmailAddress>().HasData(new EmailAddress
            {
                Id = 2,
                Email = "vick@gmail.com",
                ContactId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee")

            });

            modelBuilder.Entity<EmailAddress>().HasData(new EmailAddress

            {
                Id = 3,
                Email = "ugee@gmail.com",
                ContactId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")

            });

            modelBuilder.Entity<EmailAddress>().HasData(new EmailAddress
            {
                Id = 4,
                Email = "young@gmail.com",
                ContactId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97")
            });

            modelBuilder.Entity<EmailAddress>().HasData(new EmailAddress
            {
                Id = 5,
                Email = "hov@gmail.com",
                ContactId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97")
            });

            modelBuilder.Entity<PhoneNumber>().HasData(new PhoneNumber
            {
                PhoneNumberId = 1,
                CountryCode= "234",
                Number = "7034192342",
                ContactId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee")
            });

            modelBuilder.Entity<PhoneNumber>().HasData(new PhoneNumber
            {
                PhoneNumberId = 2,
                CountryCode = "234",
                Number = "813344567",
                ContactId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee")
            });

            modelBuilder.Entity<PhoneNumber>().HasData(new PhoneNumber
            {
                PhoneNumberId = 3,
                CountryCode = "234",
                Number = "9032456783",
                ContactId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
            });

            modelBuilder.Entity<PhoneNumber>().HasData(new PhoneNumber
            {
                PhoneNumberId = 4,
                CountryCode = "234",
                Number = "9133456432",
                ContactId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
            });

            modelBuilder.Entity<PhoneNumber>().HasData(new PhoneNumber
            {
                PhoneNumberId = 6,
                CountryCode = "234",
                Number = "8063445467",
                ContactId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97")
            });

            modelBuilder.Entity<PhoneNumber>().HasData(new PhoneNumber
            {
                PhoneNumberId = 7,
                CountryCode = "1",
                Number = "5352323433",
                ContactId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97")
            });

        }

    }
}
