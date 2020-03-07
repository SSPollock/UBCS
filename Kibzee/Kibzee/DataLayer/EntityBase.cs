using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Kibzee.DataLayer
{
    public class EntityBase : IEntity
    {
        public void SetFields(DataRow dr)
        {
            Type tp = this.GetType(); 
            foreach (PropertyInfo pi in tp.GetProperties()) 
            { 
                if (null != pi && pi.CanWrite) 
                { 
                    string nm = pi.PropertyType.Name.ToUpper(); 
                    string nmfull = pi.PropertyType.FullName.ToUpper(); 
                } 
            }
        }
    }
}
