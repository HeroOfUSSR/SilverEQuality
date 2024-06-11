using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverEQuality_Context.Models
{
    public partial class Document
    {
        public int IdDocument { get; set; }

        public string TitleDocument { get; set; } = null!;

        public byte[]? FileDocument { get; set; }
    }
}
