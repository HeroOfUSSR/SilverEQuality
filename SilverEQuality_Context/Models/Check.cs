using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class Check
    {
        public int IdCheck { get; set; }
        public DateTime DateCheck { get; set; }
        public int DepartmentCheck { get; set; }
        public decimal NormCheck { get; set; }
        public int SilverTypeCheck { get; set; }
        public decimal CoverageCheck { get; set; }
        public int AmountCheck { get; set; }
        public int DecimalCheck { get; set; }
        public int? OrderCheck { get; set; }

        public virtual DecimalNumber DecimalCheckNavigation { get; set; } = null!;
        public virtual Order? OrderCheckNavigation { get; set; }
        public virtual Department DepartmentCheckNavigation { get; set; } = null!;
        public virtual SilverType SilverTypeCheckNavigation { get; set; } = null!;
    }
}
