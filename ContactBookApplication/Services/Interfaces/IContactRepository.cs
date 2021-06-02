using ContactBookApplication.Entities;
using ContactBookApplication.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Services
{
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        void DeleteContact(Contact contact);
        void UpdateContact(Contact contact);
        bool ContactExist(Contact contact);
        bool UpdatePhoto(Guid contactId,Contact contact);
        IEnumerable<Contact> GetContacts();
        IEnumerable<Contact> GetContacts(ContactResourceParameters contactResoruceParameters);

        IEnumerable<Contact> GetContacts(ContactPageResourceParameters contactSearchResourceParameters);
        Contact GetContact(string entry);
        public bool Save();

    }
}
