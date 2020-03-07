using CoreConcepts.Pages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CoreConcepts.Pages
{
    public class MyConfigModel : PageModel
    {
        IConfiguration _config; 

        public string Message { get; set; }

        public MyConfigModel(IConfiguration config) 
        { 
            _config = config;
        }

        public void OnGet() 
        { 
            string accessId = _config["AppSettings:AccessID"]; 
            var connStr = _config.GetConnectionString("ComplexDb2"); 
            string out1 = "Access ID:" + accessId + "<br/>" + 
                "Conn Str:" + connStr + "<br/>";
            // strongly typed AppSettings reading             
            var appset = _config.GetSection("AppSettings").Get<AppSet>();             
            string out2 = appset.AppInfo.Ver + ":" + appset.AccessID + 
                ":" + appset.Mode + ":" + appset.AppInfo.CreatedBy + 
                ":" + appset.AppInfo.CreationDate;             
            Message = out1 + out2;
        }
    }
}