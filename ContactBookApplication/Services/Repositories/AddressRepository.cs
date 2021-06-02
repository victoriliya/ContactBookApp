using ContactBookApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Services
{
    public class AddressRepository : IAddressRepository
    {
        public void AddAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public bool AddressExist(Address address)
        {
            throw new NotImplementedException();
        }

        public void DeleteAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public Address GetAddress(Guid addressId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAddresses()
        {
            throw new NotImplementedException();
        }

        public void UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
