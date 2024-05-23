using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class Order
    {
        public Order()
        {
            Checks = new HashSet<Check>();
            PartNecessaries = new HashSet<PartNecessary>();
            Comments = new HashSet<Comment>();
        }

        public int IdOrder { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime? DateEndOrder { get; set; }
        public int ManufacturerOrder { get; set; }
        public int? PriorityOrder { get; set; }
        public int StatusOrder { get; set; }
        public string? DescOrder { get; set; }
        public int? AppointedOrder { get; set; }
        public decimal? PaymentOrder { get; set; }

        public virtual User? AppointedOrderNavigation { get; set; }
        public virtual Priority? PriorityOrderNavigation { get; set; }
        public virtual Status StatusOrderNavigation { get; set; } = null!;
        public virtual Manufacturer ManufacturerOrderNavigation { get; set; } = null!;

        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<PartNecessary> PartNecessaries { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
