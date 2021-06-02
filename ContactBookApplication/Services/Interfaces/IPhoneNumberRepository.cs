using ContactBookApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Services
{
    public interface IPhoneNumberRepository
    {
        void AddPhoneNumber(PhoneNumber phoneNumber);
        void DeletePhoneNumber(PhoneNumber phoneNumber);
        void UpdatePhoneNumber(PhoneNumber phoneNumber);
        bool PhoneNumberExist(PhoneNumber phoneNumber);
        IEnumerable<PhoneNumber> GetPhoneNumbers();
        PhoneNumber GetPhoneNumber(PhoneNumber phoneNumber);
    }
}
