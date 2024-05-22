using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class Norm
    {
        public int IdNorm { get; set; }
        public int DecimalNorm { get; set; }
        public int SilverTypeNorm { get; set; }
        public decimal TitleNorm { get; set; }
        public int DepartmentNorm { get; set; }

        public virtual DecimalNumber DecimalNormNavigation { get; set; } = null!;
        public virtual SilverType SilverTypeNormNavigation { get; set; } = null!;
    }
}
