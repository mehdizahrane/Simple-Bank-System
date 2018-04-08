using System;
using Microsoft.AspNetCore.Mvc;
using SimpleBankSystem.Models.Repository;
using SimpleBankSystem.Models;
namespace Simple_Bank_System.Controllers
{
    public class BankAccountController : Controller
    {
        private IBankAccountRepository bankAccountRepository;

        private IUserRepository userRepository;
        public BankAccountController(IBankAccountRepository bankRepo, IUserRepository userRepo)
        {
            bankAccountRepository = bankRepo;
            userRepository = userRepo;
        }
        public ActionResult Index() => 
        View(bankAccountRepository.GetBankAccountForUser(userRepository.GetOneUserByEmail("user@email.com").Id));
    }
}