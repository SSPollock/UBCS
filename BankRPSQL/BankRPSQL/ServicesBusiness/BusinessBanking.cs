using BankRPSQL.DataLayer;
using BankRPSQL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPSQL.ServicesBusiness
{
    public class BusinessBanking : IBusinessBanking
    {
        IRepositoryBanking _irepbank = null; 
        public BusinessBanking(IRepositoryBanking ibank) 
        { 
            _irepbank = ibank; 
        }

        public BusinessBanking() : this(new Repository()) { }

        public decimal GetCheckingBalance(long checkingAccountNum) 
        { 
            return _irepbank.GetCheckingBalance(checkingAccountNum); 
        }

        public decimal GetSavingsBalance(long savingsAccountNum) 
        { 
            return _irepbank.GetSavingsBalance(savingsAccountNum); 
        }

        public long GetCheckingAccountNumForUser(string username) 
        { 
            return _irepbank.GetCheckingAccountNumForUser(username); 
        }

        public long GetSavingsAccountNumForUser(string username) 
        { 
            return _irepbank.GetSavingsAccountNumForUser(username); 
        }

        public bool TransferCheckingToSavings(long checkingAccountNum, long savingsAccountNum, decimal amount) 
        { 
            return _irepbank.TransferCheckingToSavings(checkingAccountNum, savingsAccountNum, amount, 0); 
        }

        public bool TransferSavingsToChecking(long checkingAccountNum, long savingsAccountNum, decimal amount)
        {
            throw new NotImplementedException();
        }

        List<TransactionHistoryVM> IBusinessBanking.GetTransactionHistory(long checkingAccountNum) 
        { 
            return _irepbank.GetTransactionHistory(checkingAccountNum); 
        }
    }
}
