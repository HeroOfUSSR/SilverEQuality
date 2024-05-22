using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class Priority
    {
        public Priority()
        {
            Orders = new HashSet<Order>();
            SilverRequests = new HashSet<SilverRequest>();
        }

        public int IdPriority { get; set; }
        public string TitlePriority { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SilverRequest> SilverRequests { get; set; }
    }
}
