using AutoMapper;
using ContactBookApplication.Entities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Profiles
{
    public class ContactsProfile : Profile
    {
        public ContactsProfile()
        {
            CreateMap<Contact, Models.ContactDto>()
            .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.Salutation} {src.FirstName} {src.SecondName} {src.OtherName}")
                    )
            .ForMember(dest => dest.Addresses, opt => opt.MapFrom(itm => AddressToStringArray(itm.Addresses)))
            .ForMember(dest => dest.Emails, opt => opt.MapFrom(itm => EmailToStringArray(itm.Emails)))
            .ForMember(dest => dest.PhoneNumbers, opt => opt.MapFrom(itm => PhoneNumberToStringArray(itm.PhoneNumbers)));
            CreateMap<Models.ContactForCreationDto, Contact>();
            CreateMap<Contact, Models.ContactForUpdateDto>();
            CreateMap<Models.ContactForUpdateDto, Contact>();


        }

        private object AddressToStringArray(ICollection<Address> addresses)
        {
            var newAddresses = new List<string>();
            foreach (var address in addresses)
            {
                newAddresses.Add($"{address.StreetNumber} {address.StreetName} {address.City} {address.State}  {address.Country} {address.PostCode}");
            }

            return newAddresses;
        }

        private object EmailToStringArray(ICollection<EmailAddress> emailAddresses)
        {
            var newEmails = new List<string>();
            foreach (var email in emailAddresses)
            {
                newEmails.Add($"{email.Email}");
            }

            return newEmails;
        }

        private object PhoneNumberToStringArray(ICollection<PhoneNumber> phoneNumbers)
        {
            var newPhoneNumbers = new List<string>();
            foreach (var phoneNumber in phoneNumbers)
            {
                newPhoneNumbers.Add($"+{phoneNumber.CountryCode} {phoneNumber.Number}");
            }

            return newPhoneNumbers;
        }


    }
}
