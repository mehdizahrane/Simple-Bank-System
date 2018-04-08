using SimpleBankSystem.Models;
using System.Collections.Generic;
namespace SimpleBankSystem.Models.Repository
{
    public interface IUserRepository
    {
        List<AppIdentityUser> Users { get; }

        AppIdentityUser GetOneUserById(string userId);

        AppIdentityUser GetOneUserByEmail(string userId);
    }
}