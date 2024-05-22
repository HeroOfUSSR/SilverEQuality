using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class PartNecessary
    {
        public int IdNecessary { get; set; }
        public int PartNecessary1 { get; set; }
        public int OrderNecessary { get; set; }
        public int AmountNecessary { get; set; }

        public virtual Order OrderNecessaryNavigation { get; set; } = null!;
        public virtual Part PartNecessary1Navigation { get; set; } = null!;
    }
}
