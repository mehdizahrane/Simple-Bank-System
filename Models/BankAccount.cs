using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleBankSystem.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        
        public long AccountNumber { get; set; }


        [Required(ErrorMessage = "Please specify an account name.")]
        [MaxLength(25, ErrorMessage = "The account name must not exced 25 characters.")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Please specify an account password.")]
        [MinLength(8, ErrorMessage = "The password must contain at least 8 characters.")]
        [MaxLength(10, ErrorMessage = "The password must not exced 10 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please specify an account balance.")]
        public decimal Balance { get; set; }

        public DateTime CreatedDate { get; set; }

        public string AccountOwnerId { get; set; }

         [ForeignKey("AccountOwnerId")]
         public AppIdentityUser AccountOwner { get; set; }

    }
}