using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class Part
    {
        public Part()
        {
            PartNecessaries = new HashSet<PartNecessary>();
        }

        public int IdPart { get; set; }
        public decimal? WeightPart { get; set; }
        public int DecimalPart { get; set; }
        public decimal? CostPart { get; set; }
        public byte[]? ImagePart { get; set; }
        public string NamePart { get; set; }
        

        public virtual DecimalNumber DecimalPartNavigation { get; set; } = null!;
        public virtual ICollection<PartNecessary> PartNecessaries { get; set; }
    }
}
