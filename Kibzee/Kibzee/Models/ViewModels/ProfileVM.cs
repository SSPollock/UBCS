using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kibzee.Models.ViewModels
{
    public class ProfileVM
    {
        // non null UserName will serve as indicator that profile is complete
        public string UserName { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Instruments> InstrumentList { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AltPhone { get; set; }
        public string AltEmail { get; set; }
    }
}
