using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class DecimalNumber
    {
        public DecimalNumber()
        {
            Checks = new HashSet<Check>();
            Norms = new HashSet<Norm>();
            Parts = new HashSet<Part>();
        }

        public int IdDecimal { get; set; }
        public string TitleDecimal { get; set; } = null!;

        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<Norm> Norms { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}
