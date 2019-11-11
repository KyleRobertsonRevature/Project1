using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Details { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
    }
}
