using BankRPEF.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPEF.ServicesBusiness
{
    public interface IBusinessBanking
    {
        decimal GetCheckingBalance(long checkingAccountNum); 
        decimal GetSavingsBalance(long savingsAccountNum); 
        long GetCheckingAccountNumForUser(string username); 
        long GetSavingsAccountNumForUser(string username); 
        bool TransferCheckingToSavings(long checkingAccountNum, long savingsAccountNum, decimal amount); 
        bool TransferSavingsToChecking(long checkingAccountNum, long savingsAccountNum, decimal amount); 
        List<TransactionHistoryVM> GetTransactionHistory(long checkingAccountNum);
    }
}
