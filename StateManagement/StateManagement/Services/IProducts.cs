using StateManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement.Services
{
    public interface IProducts
    {
        List<Product> GetProducts();
    }
}
