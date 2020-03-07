using System;
using System.Collections.Generic;

namespace Kibzee.Models
{
    public partial class ContactDetails
    {
        public int ContactId { get; set; }
        public int UserId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AltPhone { get; set; }
        public string AltEmail { get; set; }
    }
}
