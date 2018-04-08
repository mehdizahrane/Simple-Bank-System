using System;
using SimpleBankSystem.Models;
using SimpleBankSystem.Models.Repository;
using System.Collections.Generic;
using System.Linq;
namespace SimpleBankSystem.Models.Repository.FakeRepository
{
    public class FakeUserRepository : IUserRepository
    {
        public List<AppIdentityUser> Users => new List<AppIdentityUser>()
        {
            new AppIdentityUser(){ Id = "c2122d17-2118-46d2-a41a-5b20c152d8c1", Email = "user@email.com" },
            new AppIdentityUser(){ Id = "a1b642f9-4e0a-43a8-a80a-67591aadcf24", Email = "anotherUser@email.com" }
        };

        public AppIdentityUser GetOneUserById(string userId)
        {
            return this.Users.SingleOrDefault(u => u.Id.Equals(userId));
        }

        public AppIdentityUser GetOneUserByEmail(string userEmail)
        {
            return this.Users.SingleOrDefault(u => u.Email.Equals(userEmail));
        }
    }
}