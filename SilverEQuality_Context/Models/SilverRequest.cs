using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class SilverRequest
    {
        public int IdRequest { get; set; }
        public int SilverTypeRequest { get; set; }
        public int UserRequest { get; set; }
        public int AmountRequest { get; set; }
        public int? PriorityRequest { get; set; }
        public int StatusRequest { get; set; }

        public decimal? CostRequest { get; set; }
        public string? DescRequest {  get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime? DateEndRequest { get; set; }
        public DateTime? DateClosedOrder { get; set; }

        public virtual Status StatusRequestNavigation { get; set; } = null!;
        public virtual Priority? PriorityRequestNavigation { get; set; }
        public virtual SilverType SilverTypeRequestNavigation { get; set; } = null!;
        public virtual User UserRequestNavigation { get; set; } = null!;
    }
}
