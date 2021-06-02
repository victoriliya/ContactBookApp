using ContactBookApplication.Entities;
using ContactBookApplication.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Services.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthRepository(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> MakeAdmin(User user)
        {
            var makeAdmin = await _userManager.AddToRoleAsync(user, "Admin");
            if (makeAdmin.Succeeded)
                return true;
            return false;
        }
        public async Task<bool> MakeRegular(User user)
        {
            var makeAdmin = await _userManager.AddToRoleAsync(user, "Regular");
            if (makeAdmin.Succeeded)
                return true;
            return false;
        }
    }
}
