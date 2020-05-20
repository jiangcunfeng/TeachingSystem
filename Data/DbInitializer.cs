using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TeachingSystem.Data {
    public static class ApplicationDbInitializer {
        public static void SeedUsers(UserManager<User> userManager) {
            if (userManager.FindByNameAsync("admin").Result == null) {
                User user = new User {
                UserName = "admin",
                Email = "abc@xyz.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "admin").Result;

                if (result.Succeeded) {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}