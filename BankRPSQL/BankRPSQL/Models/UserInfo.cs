using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPSQL.Models
{
    public class UserInfo
    {
        public long CheckingAccountNumber { get; set; }
        public long SavingsAccountNumber { get; set; }
        public string UserName { get; set; }
    }
}
