using ContactBookApplication.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.DbContexts
{
    public class Seeder
    {
        public static async Task<bool> SeedRole(ContactBookContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string[] roleList = { "Admin", "Regular" };
            if (!context.Roles.Any())
            {
                for (int i = 0; i < roleList.Length; i++)
                {
                    var role = new IdentityRole(roleList[i]);
                    await roleManager.CreateAsync(role);
                }
                return true;
            }
            return false;
        }
    }
}
