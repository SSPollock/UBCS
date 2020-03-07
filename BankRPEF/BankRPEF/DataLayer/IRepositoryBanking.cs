using BankRPEF.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPEF.DataLayer
{
    public interface IRepositoryBanking
    {
        decimal GetCheckingBalance(long checkingAccountNum); 
        decimal GetSavingsBalance(long savingsAccountNum); 
        long GetCheckingAccountNumForUser(string username); 
        long GetSavingsAccountNumForUser(string username); 
        bool TransferCheckingToSavings(long checkingAccountNum, long savingsAccountNum, decimal amount, decimal transactionFee); 
        bool TransferSavingsToChecking(long checkingAccountNum, long savingsAccountNum, decimal amount, decimal transactionFee); 
        List<TransactionHistoryVM> GetTransactionHistory(long checkingAccountNum);
    }
}
