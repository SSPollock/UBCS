using BankRPSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPSQL.DataLayer
{
    public interface IBusinessAuthentication
    {
        UserInfo GetUserInfo(string username);
    }
}
