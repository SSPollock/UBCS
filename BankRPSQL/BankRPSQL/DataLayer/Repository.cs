using BankRPSQL.Models;
using BankRPSQL.Models.ViewModels;
using BankRPSQL.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPSQL.DataLayer
{
    public class Repository : IRepositoryBanking, IRepositoryAuthentication
    {
        // Repository needs to communicate with DataAcess sublayer         
        // We should use loose coupling so that we can can         
        // use DependencyInjection to test each sublayer         
        IDataAccess _idac = null;         
        public Repository(IDataAccess idac)         
        {             
            _idac = idac;         
        }         

        public Repository() : this(new SQLDataAccess())         { } 

        public decimal GetCheckingBalance(long checkingAccountNum)
        {
            decimal balance = 0; 
            try
            {
                string sql = "select balance from CheckingAccounts where CheckingAccountNumber=@CheckingAccountNumber"; 
                List<DbParameter> ParamList = new List<DbParameter>(); 
                SqlParameter p1 = new SqlParameter("@CheckingAccountNumber", SqlDbType.BigInt); 
                p1.Value = checkingAccountNum; ParamList.Add(p1); 
                object obj = _idac.GetSingleAnswer(sql, ParamList); 
                if (obj != null) 
                    balance = decimal.Parse(obj.ToString());
            }
            catch (Exception e) 
            { 
                throw; 
            }
            return balance;
        }

        public decimal GetSavingsBalance(long savingsAccountNum) 
        { 
            decimal balance = 0; 
            try 
            { 
                string sql = "select balance from SavingsAccounts where SavingsAccountNumber=@SavingsAccountNumber"; 
                List<DbParameter> ParamList = new List<DbParameter>(); 
                SqlParameter p1 = new SqlParameter("@SavingsAccountNumber", SqlDbType.BigInt); 
                p1.Value = savingsAccountNum; ParamList.Add(p1); 
                object obj = _idac.GetSingleAnswer(sql, ParamList); 
                if (obj != null) 
                    balance = decimal.Parse(obj.ToString()); 
            } 
            catch (Exception e) 
            { 
                throw; 
            } 
            return balance; 
        }

        public long GetCheckingAccountNumForUser(string username) 
        { 
            long checkingAccountNum = 0; 
            try 
            { 
                string sql = "select CheckingAccountNumber from CheckingAccounts where " + "Username=@Username"; 
                List<DbParameter> PList = new List<DbParameter>(); 
                DbParameter p1 = new SqlParameter("@Username", SqlDbType.VarChar, 50); 
                p1.Value = username; 
                PList.Add(p1); 
                object obj = _idac.GetSingleAnswer(sql, PList); 
                if (obj != null) 
                    checkingAccountNum = long.Parse(obj.ToString()); 
            } 
            catch (Exception e) 
            { 
                throw; 
            } 
            return checkingAccountNum; 
        }

        public long GetSavingsAccountNumForUser(string username)
        {
            long savingsAccountNum = 0; 
            try
            { 
                string sql = "select SavingsAccountNumber from SavingsAccounts where " + "Username=@Username"; 
                List<DbParameter> PList = new List<DbParameter>(); 
                DbParameter p1 = new SqlParameter("@Username", SqlDbType.VarChar, 50); 
                p1.Value = username; PList.Add(p1); 
                object obj = _idac.GetSingleAnswer(sql, PList); 
                if (obj != null) 
                    savingsAccountNum = long.Parse(obj.ToString()); 
            }             
            catch (Exception e) 
            { 
                throw; 
            }
            return savingsAccountNum;
        }

        public bool TransferCheckingToSavings(long checkingAccountNum, long savingsAccountNum, decimal amount, decimal transactionFee)
        {             
            // transfer checking to saving has to be done as a transaction             
            // transactions are assocated with a connection             
            bool ret = false;             
            string CONNSTR = ConnectionStringHelper.CONNSTR;             
            SqlConnection conn = new SqlConnection(CONNSTR);             
            SqlTransaction sqtr = null;             
            try             
            {                 
                conn.Open();                 
                sqtr = conn.BeginTransaction();                 
                int rows = UpdateCheckingBalanceTR(checkingAccountNum, -1*amount, conn, sqtr, true);                 
                if (rows == 0)                     
                    throw new Exception("Problem in transferring from Checking Account.."); 
                object obj = GetCheckingBalanceTR(checkingAccountNum, conn, sqtr, true); 
                if (obj != null)
                {
                    if (decimal.Parse(obj.ToString()) < 0)  // exception causes transaction to be rolled back                             
                        throw new Exception("Insufficient funds in Checking Account - rolling back transaction");                     
                } 
                rows = UpdateSavingBalanceTR(savingsAccountNum, amount, conn, sqtr, true); 
                if (rows == 0) 
                    throw new Exception("Problem in transferring to Savings Account.."); 
                rows = AddToTransactionHistoryTR(checkingAccountNum, savingsAccountNum, amount, 100, transactionFee, conn, sqtr, true); 
                if (rows == 0) 
                    throw new Exception("Problem in transferring to Savings Account..");
                else
                {
                    sqtr.Commit(); 
                    ret = true;                     
                    // clear the cache 
                    //CacheAbstraction cabs = new CacheAbstraction();                     
                    //cabs.Remove("TRHISTORY");                 
                }             
            }             
            catch (Exception e)             
            {                 
                throw;             
            }             
            finally             
            {                 
                conn.Close();             
            }             
            return ret;         
        } 

        public bool TransferSavingsToChecking(long checkingAccountNum, long savingsAccountNum, decimal amount, decimal transactionFee) 
        { 
            throw new NotImplementedException(); 
        }

        private int UpdateCheckingBalanceTR(long checkingAccountNum, decimal amount, DbConnection conn, DbTransaction sqtr, bool doTransaction)
        {
            int rows = 0; try
            {
                string sql1 = "Update CheckingAccounts set Balance=Balance+@Amount where CheckingAccountNumber=@CheckingAccountNumber"; 
                List<DbParameter> ParamList = new List<DbParameter>(); 
                SqlParameter p1 = new SqlParameter("@CheckingAccountNumber", SqlDbType.BigInt); 
                p1.Value = checkingAccountNum; ParamList.Add(p1); 
                SqlParameter p2 = new SqlParameter("@Amount", SqlDbType.Decimal); 
                p2.Value = amount; ParamList.Add(p2); 
                rows = _idac.InsertUpdateDelete(sql1, ParamList, conn, sqtr, doTransaction); // part of transaction             
            }             
            catch (Exception e)             
            {                 
                throw;             
            }             
            return rows;         
        } 

        private int UpdateSavingBalanceTR(long savingsAccountNum, decimal amount, DbConnection conn, DbTransaction sqtr, bool doTransaction)
        {
            int rows = 0; try
            {
                string sql1 = "Update SavingsAccounts set Balance=Balance+@Amount where SavingsAccountNumber=@SavingsAccountNumber"; 
                List<DbParameter> ParamList = new List<DbParameter>(); 
                SqlParameter p1 = new SqlParameter("@SavingsAccountNumber", SqlDbType.BigInt); 
                p1.Value = savingsAccountNum;
                ParamList.Add(p1); 
                SqlParameter p2 = new SqlParameter("@Amount", SqlDbType.Decimal); 
                p2.Value = amount; ParamList.Add(p2); 
                rows = _idac.InsertUpdateDelete(sql1, ParamList, conn, sqtr, doTransaction);  // part of transaction             
            }             
            catch (Exception e)             
            {                 
                throw;             
            }             
            return rows;         
        } 

        private object GetCheckingBalanceTR(long checkingAccountNum, DbConnection conn, DbTransaction sqtr, bool doTransaction) 
        { 
            object objBal = null; 
            try 
            { 
                string sql2 = "select Balance from CheckingAccounts where CheckingAccountNumber=@CheckingAccountNumber"; 
                List<DbParameter> ParamList2 = new List<DbParameter>(); 
                SqlParameter pa = new SqlParameter("@CheckingAccountNumber", SqlDbType.BigInt); 
                pa.Value = checkingAccountNum; 
                ParamList2.Add(pa); 
                objBal = _idac.GetSingleAnswer(sql2, ParamList2, conn, sqtr, doTransaction); 
            } 
            catch (Exception e) 
            { 
                throw; 
            } 
            return objBal; 
        }

        private int AddToTransactionHistoryTR(
            long checkingAccountNum, long savingsAccountNum, decimal amount, int transTypeId, decimal transFee, 
            DbConnection conn, DbTransaction sqtr, bool doTransaction)
        {
            int rows = 0; 
            try
            {
                string sql1 = "insert into TransactionHistories(TransactionDate,CheckingAccountNumber,SavingsAccountNumber," + 
                    "Amount,TransactionFee,TransactionTypeId) values (@TransactionDate,@CheckingAccountNumber,@SavingsAccountNumber," + 
                    "@Amount,@TransactionFee,@TransactionTypeId)"; 
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p0 = new SqlParameter("@TransactionDate", SqlDbType.DateTime);
                p0.Value = DateTime.Now;
                ParamList.Add(p0);
                SqlParameter p1 = new SqlParameter("@CheckingAccountNumber", SqlDbType.BigInt); 
                p1.Value = checkingAccountNum; 
                ParamList.Add(p1); 
                SqlParameter p2 = new SqlParameter("@SavingsAccountNumber", SqlDbType.BigInt); 
                p2.Value = savingsAccountNum;
                ParamList.Add(p2); 
                SqlParameter p3 = new SqlParameter("@Amount", SqlDbType.Decimal); 
                p3.Value = amount; 
                ParamList.Add(p3); 
                SqlParameter p4 = new SqlParameter("@TransactionFee", SqlDbType.Decimal); 
                p4.Value = transFee; 
                ParamList.Add(p4); 
                SqlParameter p5 = new SqlParameter("@TransactionTypeId", SqlDbType.Int); 
                p5.Value = transTypeId; 
                ParamList.Add(p5); 
                rows = _idac.InsertUpdateDelete(sql1, ParamList, conn, sqtr, doTransaction);  // part of transaction             
            }             
            catch (Exception e)             
            {                 
                throw;             
            }             
            return rows;         
        } 

        public List<TransactionHistoryVM> GetTransactionHistory(long checkingAccountNum) 
        { 
            List<TransactionHistoryVM> THList = null; 
            try 
            { 
                string sql = "select th.*, trt.TransactionTypeName from TransactionHistories th " +
                    "inner join TransactionTypes trt on th.TransactionTypeId=trt.TransactionTypeId " +
                    "where CheckingAccountNumber=@CheckingAccountNumber";
                List<DbParameter> ParamList = new List<DbParameter>(); 
                SqlParameter p1 = new SqlParameter("@CheckingAccountNumber", SqlDbType.BigInt); 
                p1.Value = checkingAccountNum; ParamList.Add(p1); 
                DataTable dt = _idac.GetManyRowsCols(sql, ParamList); 
                string amt = dt.Rows[0]["Amount"].ToString(); 
                THList = DBList.ToList<TransactionHistoryVM>(dt); 
            } 
            catch (Exception e) 
            { 
                throw; 
            } 
            return THList; 
        }

        public UserInfo GetUserInfo(string username) 
        { 
            UserInfo uinfo = new UserInfo(); 
            try 
            { 
                string sql1 = "select CheckingAccountNumber from CheckingAccounts " + "where Username=@Username"; 
                List<DbParameter> ParamList1 = new List<DbParameter>(); 
                SqlParameter p1 = new SqlParameter("@Username", SqlDbType.VarChar, 50); 
                p1.Value = username; 
                ParamList1.Add(p1); 
                object obj1 = _idac.GetSingleAnswer(sql1, ParamList1); 
                if (obj1 != null) 
                { 
                    uinfo.CheckingAccountNumber = long.Parse(obj1.ToString()); 
                    string sql2 = "select SavingsAccountNumber from SavingsAccounts " + "where Username=@Username"; 
                    List<DbParameter> ParamList2 = new List<DbParameter>(); 
                    SqlParameter p1a = new SqlParameter("@Username", SqlDbType.VarChar, 50); 
                    p1a.Value = username; 
                    ParamList2.Add(p1a); 
                    object obja = _idac.GetSingleAnswer(sql2, ParamList2); 
                    if (obja != null) 
                        uinfo.SavingsAccountNumber = long.Parse(obja.ToString()); 
                } 
                else 
                    return null; 
            } 
            catch (Exception e) 
            { 
                throw; 
            } 
            return uinfo; 
        }
    }
}
