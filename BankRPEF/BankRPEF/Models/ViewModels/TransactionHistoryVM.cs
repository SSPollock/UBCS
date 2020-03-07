using BankRPEF.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPEF.Models.ViewModels
{
    public class TransactionHistoryVM : TransactionHistory 
    {
        public string TransactionTypeName { get; set; } // added field 
    }
}
