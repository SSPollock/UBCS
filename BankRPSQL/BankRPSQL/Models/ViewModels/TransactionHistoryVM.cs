using BankRPSQL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPSQL.Models.ViewModels
{
    public class TransactionHistoryVM : TransactionHistory 
    {
        public string TransactionTypeName { get; set; } // added field 
    }
}
