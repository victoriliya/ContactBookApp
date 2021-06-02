using ContactBookApplication.Entities;
using ContactBookApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Services.Interfaces
{
    public interface IUserRepository
    {
        Task<User> RegisterUser(RegisterUserDto user);
        Task<bool> MakeRegular(User user);
        Task<bool> MakeAdmin(User user);
        Task<User> GetUser(string email);

    }
}
