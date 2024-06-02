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
        public decimal? CostRequest { get; set; }
        public string? DescRequest {  get; set; }
        public DateTime DateRequest { get; set; }


        public virtual Priority? PriorityRequestNavigation { get; set; }
        public virtual SilverType SilverTypeRequestNavigation { get; set; } = null!;
        public virtual User UserRequestNavigation { get; set; } = null!;
    }
}
