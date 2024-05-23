using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverEQuality_Context.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Orders = new HashSet<Order>();
        }

        public int IdManufacturer { get; set; }
        public string NameManufacturer { get; set; } = null!;
        public byte[]? ImageManufacturer { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
