using System;
using SimpleBankSystem.Models;
using SimpleBankSystem.Models.Repository;
using System.Collections.Generic;
namespace SimpleBankSystem.Models.Repository.FakeRepository
{
    public class FakeBankAccountRepository : IBankAccountRepository
    {
       public List<BankAccount> BankAccounts => new List<BankAccount>
       {
           // Password = Mido@1995
           new BankAccount() { Id = 1, AccountName = "XYZ", AccountNumber = 340731158653492, CreatedDate = DateTime.Now, Balance = 5000.87m, AccountOwnerId = "c2122d17-2118-46d2-a41a-5b20c152d8c1", Password = "cb2939c1bf16ec31716d59c4e5abc379" },
           // Password = Mido@
           new BankAccount() { Id = 2, AccountName = "ABC", AccountNumber = 349602687801483, CreatedDate = DateTime.Now, Balance = 8000.50m, AccountOwnerId = "a1b642f9-4e0a-43a8-a80a-67591aadcf24", Password = "11e2559bfc8396d93f87862c26217a9c"},
           // Password = Hello
           new BankAccount() { Id = 3, AccountName = "MNO", AccountNumber = 349602687801483, CreatedDate = DateTime.Now, Balance = 7894.56m, AccountOwnerId = "c2122d17-2118-46d2-a41a-5b20c152d8c1", Password = "8b1a9953c4611296a827abf8c47804d7"  },           
       };
    }
}