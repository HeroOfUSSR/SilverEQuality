using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int IdRole { get; set; }
        public string TitleRole { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
