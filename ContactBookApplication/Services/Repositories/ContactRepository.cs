using ContactBookApplication.DbContexts;
using ContactBookApplication.Entities;
using ContactBookApplication.ResourceParameters;
using ContactBookApplication.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Services
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactBookContext _context;
        public ContactRepository(ContactBookContext context)
        {
            _context = context;
        }

        public void AddContact(Contact contact)
        {

            if (contact == null)
            {
                throw new ArgumentNullException(nameof(contact));
            }

            // the repository fills the id (instead of using identity columns)
            var NewContactId = Guid.NewGuid(); ;
            contact.ContactId = NewContactId;

            foreach (var email in contact.Emails)
            {
                email.ContactId = NewContactId;
            }

            foreach (var phoneNumber in contact.PhoneNumbers)
            {
                phoneNumber.ContactId = NewContactId;
            }

            foreach (var address in contact.Addresses)
            {
                address.ContactId = NewContactId;
            }

            _context.Contacts.Add(contact);
        }

        public bool ContactExist(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException(nameof(contact));
            }

            _context.Contacts.Remove(contact);
        }

        public Contact GetContact(string entry)
        {
            Contact contact = new Contact();
            if (string.IsNullOrWhiteSpace(entry))
            {
                throw new ArgumentNullException(nameof(entry));
                
            }
            else {

                Guid userId;
                if (Guid.TryParse(entry, out userId))
                {
                    contact = _context.Contacts.Where(x => x.ContactId == userId).Include(x => x.PhoneNumbers).Include(x => x.Emails).FirstOrDefault();
                }
                else if (entry.IsValidEmail())
                {
                    var email = _context.Emails.Where(x => x.Email == entry).FirstOrDefault();
                    contact = _context.Contacts.Where(x => x.ContactId == email.ContactId).Include(x => x.PhoneNumbers).Include(x => x.Emails).FirstOrDefault();
                }
            }

            return contact;
        }


        public IEnumerable<Contact> GetContacts(ContactResourceParameters contactResoruceParameters)
        {
            if (contactResoruceParameters == null)
            {
                throw new ArgumentNullException(nameof(contactResoruceParameters));
            }

            if ( string.IsNullOrWhiteSpace(contactResoruceParameters.SearchQuery))
            {
                return GetContacts();
            }

            var collection = _context.Contacts as IQueryable<Contact>;

            if (!string.IsNullOrWhiteSpace(contactResoruceParameters.SearchQuery))
            {
                contactResoruceParameters.SearchQuery = contactResoruceParameters.SearchQuery.Trim();
                collection = collection.Where(a => 
                    a.NickName.Contains(contactResoruceParameters.SearchQuery)
                   || a.FirstName.Contains(contactResoruceParameters.SearchQuery)
                   || a.SecondName.Contains(contactResoruceParameters.SearchQuery)
                   || a.OtherName.Contains(contactResoruceParameters.SearchQuery)
                   );
            }

            return collection.ToList();

        }

        public IEnumerable<Contact> GetContacts(ContactPageResourceParameters contactSearchResourceParameters)
        {

             return _context.Contacts.Include(x => x.Addresses).Include(x => x.PhoneNumbers).Include(x => x.Emails).Skip((contactSearchResourceParameters.PageNumber - 1) * contactSearchResourceParameters.PageSize).Take(contactSearchResourceParameters.PageSize).ToList();
        }


        public IEnumerable<Contact> GetContacts()
        {
            var contacts = _context.Contacts.Include(x => x.Addresses).Include(x => x.PhoneNumbers).Include(x => x.Emails).ToList();

            return contacts;

        }

        public bool UpdatePhoto(Guid contactId, Contact contact)
        {
            var foundcontact = _context.Contacts.Where(x => x.ContactId == contactId).FirstOrDefault();
            foundcontact.PhotoUrl = contact.PhotoUrl; 
            return (_context.SaveChanges() >= 0);
        }
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateContact(Contact contact)
        {
            
        }

    }
}
