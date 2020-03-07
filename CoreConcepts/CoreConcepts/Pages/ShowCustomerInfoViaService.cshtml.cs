using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreConcepts.Pages.Models;
using CoreConcepts.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreConcepts
{
    public class ShowCustomerInfoViaServiceModel : PageModel
    {
        IStocks _ist = null; 
        
        public ShowCustomerInfoViaServiceModel(IStocks ist) 
        { 
            _ist = ist; 
        }

        public CustomerInfo CInfo { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {             
            // get customer info from DB             
            CInfo = new CustomerInfo();             
            CInfo.FirstName = "Bill";             
            CInfo.LastName = "Baker";             
            CInfo.Email = "bill@yahoo.com";             
            // check DB and get the stock prices for stocks in the portfolio             
            CInfo.STList = new List<StockInfo>();             
            StockInfo s1 = new StockInfo { Symbol = "IBM", Price = 143.45 };             
            CInfo.STList.Add(s1);             
            StockInfo s2 = new StockInfo { Symbol = "AAPL", Price = 195.75 };             
            CInfo.STList.Add(s2);                          
            // optional - get real stock prices from an API             
            CInfo.STList = await _ist.GetPrices(CInfo.STList);             
            return Page();         
        }   
    }
}