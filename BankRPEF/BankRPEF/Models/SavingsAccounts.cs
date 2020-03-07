using System;
using System.Collections.Generic;

namespace BankRPEF.Models
{
    public partial class SavingsAccounts
    {
        public string Username { get; set; }
        public long SavingsAccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
