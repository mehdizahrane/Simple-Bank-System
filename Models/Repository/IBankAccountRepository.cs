using SimpleBankSystem.Models;
using System.Collections.Generic;
namespace SimpleBankSystem.Models.Repository
{
    public interface IBankAccountRepository
    {
        List<BankAccount> BankAccounts { get; }

        List<BankAccount> GetBankAccountForUser(string userId);
    }
}