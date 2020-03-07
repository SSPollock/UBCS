using System;
using System.Collections.Generic;

namespace Kibzee.Models
{
    public partial class Photos
    {
        public int PhotoId { get; set; }
        public int UserId { get; set; }
        public string FileName { get; set; }
        public string PhotoName { get; set; }
        public DateTime? DateUploaded { get; set; }
        public string Caption { get; set; }
    }
}
