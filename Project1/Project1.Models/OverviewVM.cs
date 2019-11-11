using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Models
{
    public class OverviewVM
    {
        public User User { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
    }
}
