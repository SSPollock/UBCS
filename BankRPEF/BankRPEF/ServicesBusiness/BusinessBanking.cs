using BankRPEF.DataLayer;
using BankRPEF.Models;
using BankRPEF.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPEF.ServicesBusiness
{
    public class BusinessBanking :IBusinessBanking
    {
        IRepositoryBanking _irepbank = null; 
        
        public BusinessBanking(IRepositoryBanking ibank) 
        { 
            _irepbank = ibank; 
        }

        public BusinessBanking(MyBankContext context) : this(new RepositoryEF(context)) 
        { 
        }

        public decimal GetCheckingBalance(long checkingAccountNum) 
        { 
            return _irepbank.GetCheckingBalance(checkingAccountNum); 
        }

        public decimal GetSavingsBalance(long savingAccountNum) 
        { 
            return _irepbank.GetSavingsBalance(savingAccountNum); 
        }

        public long GetCheckingAccountNumForUser(string username) 
        { 
            return _irepbank.GetCheckingAccountNumForUser(username); 
        }

        public long GetSavingsAccountNumForUser(string username) 
        { 
            return _irepbank.GetSavingsAccountNumForUser(username); 
        } 

        public bool TransferCheckingToSavings(long checkingAccountNum, long savingAccountNum, decimal amount) 
        { 
            return _irepbank.TransferCheckingToSavings(checkingAccountNum, savingAccountNum, amount, 0); 
        }

        public bool TransferSavingsToChecking(long checkingAccountNum, long savingAccountNum, decimal amount) 
        { 
            throw new NotImplementedException(); 
        }

        List<TransactionHistoryVM> IBusinessBanking.GetTransactionHistory(long checkingAccountNum) 
        { 
            return _irepbank.GetTransactionHistory(checkingAccountNum); 
        }
    }
}
