﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreConcepts.Pages.Models
{
    public class AppSet 
    { 
        public int AccessID { get; set; } 
        public string Mode { get; set; } 
        public AInfo AppInfo { get; set; } 
    }


    public class AInfo 
    { 
        public string CreatedBy { get; set; } 
        public string CreationDate { get; set; } 
        public string Ver { get; set; } 
    }
}
