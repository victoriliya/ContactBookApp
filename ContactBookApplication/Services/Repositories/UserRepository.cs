using ContactBookApplication.Entities;
using ContactBookApplication.Models;
using ContactBookApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Services.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> MakeAdmin(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> MakeRegular(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> RegisterUser(RegisterUserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
