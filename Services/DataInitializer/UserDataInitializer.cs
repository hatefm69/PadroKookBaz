using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Identity;
using Entities.User;
using System.Linq;

namespace Services.DataInitializer
{
    /// <summary>
    /// تولید کننده محتوا برای کاربر
    /// </summary>
    public class UserDataInitializer : IDataInitializer
    {
        private readonly IUserRepository userRepository;

        public UserDataInitializer(IUserRepository userRepository, UserManager<User> userManager)
        {
            this.userRepository = userRepository;
            UserManager = userManager;
        }

        private readonly UserManager<User> UserManager;
        public void InitializeData()
        {
            if (!userRepository.TableNoTracking.Any(p => p.UserName == "Admin"))
            {

                var result = UserManager.CreateAsync(new User
                {
                    Id=1,
                    EmailConfirmed = false,
                    PhoneNumber = "989191945072",
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    IsActive = true,
                    UserName = "Admin",
                    Email = "admin@site.com",
                    FirstName = "administrator",
                    Gender = GenderType.Male,
                }, "1234567").Result;
            }
        }
    }
}
