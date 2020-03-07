using System;
using System.Collections.Generic;

namespace Kibzee.Models
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime PostDate { get; set; }
        public string PostContent { get; set; }
        public int NumLikes { get; set; }
    }
}
