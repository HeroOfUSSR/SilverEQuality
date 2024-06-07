using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class SilverType
    {
        public SilverType()
        {
            Checks = new HashSet<Check>();
            Norms = new HashSet<Norm>();
            SilverRequests = new HashSet<SilverRequest>();
        }

        public int CodeSilverType { get; set; }
        public string TitleSilverType { get; set; } = null!;
        public decimal? AmountSilverType { get; set; }
        public decimal? CostPerKgSilverType { get; set; }
        public byte[]? ImageSilverType { get; set; }

        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<Norm> Norms { get; set; }
        public virtual ICollection<SilverRequest> SilverRequests { get; set; }
    }
}
