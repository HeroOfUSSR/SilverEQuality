using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
            SilverRequests = new HashSet<SilverRequest>();
        }

        public int IdStatus { get; set; }
        public string TitleStatus { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SilverRequest> SilverRequests { get; set; }

    }
}
