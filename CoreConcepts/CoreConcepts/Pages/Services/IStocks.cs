using CoreConcepts.Pages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreConcepts.Pages.Services
{
    public interface IStocks
    {
        DateTime DTService { get; set; }
        Task<List<StockInfo>> GetPrices(List<StockInfo> SList);
    }
}
