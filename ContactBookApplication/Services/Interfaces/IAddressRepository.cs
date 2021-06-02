using ContactBookApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Services
{
    public interface IAddressRepository
    {
        void AddAddress(Address address);
        void DeleteAddress(Address address);
        void UpdateAddress(Address address);
        bool AddressExist(Address address);
        IEnumerable<Address> GetAddresses();
        Address GetAddress(Guid addressId);
    }
}
