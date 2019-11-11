using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
        [Required]
        public decimal InterestRate { get; set; }
        [Required]
        public int AccountNumber { get; set; }
        [Required]
        public bool IsClosed { get; set; }
        [Required]
        public string AccType { get; set; }
        public int Term { get; set; }
        public bool IsMature { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
