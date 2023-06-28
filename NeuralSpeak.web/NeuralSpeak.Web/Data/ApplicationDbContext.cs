using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeuralSpeak.Web.Data.Entities;

namespace NeuralSpeak.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
   : base(options)
        {
        }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    public static class SeedUsers
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using (RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>())
            {
                string[] roles = new string[] { "User", "Admin" };

                var newrolelist = new List<IdentityRole>();
                foreach (string role in roles)
                {
                    if (!_roleManager.Roles.Any(r => r.Name == role))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(role));
                    }
                }

                using (UserManager<IdentityUser> _userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>())
                {
                    IdentityUser user = new IdentityUser()
                    {
                        UserName = "admin@neuralspeak.com",
                        Email = "admin@neuralspeak.com",
                        LockoutEnabled = false,
                        PhoneNumber = "1234567890",
                    };
                    if (!_userManager.Users.Any(r => r.UserName == user.UserName))
                    {
                        var result = await _userManager.CreateAsync(user, "Admin@123");
                        if (result.Succeeded)
                        {
                            var adminRole = await _roleManager.FindByNameAsync("Admin");
                            if (adminRole != null)
                            {
                                IdentityResult roleresult = await _userManager.AddToRoleAsync(user, adminRole.Name);
                            }
                        }
                    }

                }
            }
        }
    }
}