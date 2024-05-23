using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverEQuality_Context.Models
{
    public partial class Comment
    {
        public int IdComment { get; set; }
        public string TextComment { get; set; }
        public int UserComment {  get; set; }
        public DateTime DateComment { get; set; }
        public int OrderComment { get; set; }

        public virtual User UserCommentNavigation { get; set; }
        public virtual Order OrderCommentNavigation { get; set; }

    }
}
