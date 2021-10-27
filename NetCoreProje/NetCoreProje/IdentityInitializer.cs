using Microsoft.AspNetCore.Identity;
using NetCoreProje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje
{
    public class IdentityInitializer
    {
        public static void OlusturAdmin(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            AppUser appUser = new AppUser
            {
                Name = "Bircan",
                SurName = "Uysal",
                UserName = "bircan"
            };
            if (userManager.FindByNameAsync("Bircan").Result == null)
            {
                var identityResult = userManager.CreateAsync(appUser,"1").Result; //şifre 1
            }
            if (roleManager.FindByNameAsync("Admin").Result == null)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin"
                };
                var ıdentityResult = roleManager.CreateAsync(role).Result;
                var result = userManager.AddToRoleAsync(appUser, role.Name).Result;
            }
        }
    }
}
