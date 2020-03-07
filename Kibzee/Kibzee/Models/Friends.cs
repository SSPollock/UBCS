using System;
using System.Collections.Generic;

namespace Kibzee.Models
{
    public partial class Friends
    {
        public int ConnectionId { get; set; }
        public int? UserId { get; set; }
        public int? FriendId { get; set; }
    }
}
