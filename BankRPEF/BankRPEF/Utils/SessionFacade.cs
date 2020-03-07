﻿using BankRPEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPEF.Utils
{
    public class SessionFacade
    {
        // purpose of Facade pattern is to provide safe access to a resource         
        // In this case, the Session object, so that name of the key         
        // cannot be mistyped, the datatype being stored in a key         
        // cannot create type casting errors         
        
        const string userinfokey = "userinfokey";  // key field         
        public static UserInfo USERINFO         
        {             
            get             
            {                 
                return HttpContextHelper.HttpCtx.Session.Get<UserInfo>(userinfokey);             
            }             
            set             
            {                 
                HttpContextHelper.HttpCtx.Session.Set<UserInfo>(userinfokey, value);             
            }         
        } 
    }
}
