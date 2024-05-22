using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            SilverRequests = new HashSet<SilverRequest>();
        }

        public int IdUser { get; set; }
        public string FullnameUser { get; set; } = null!;
        public DateTime DateOfBirthUser { get; set; }
        public string? EmailUser { get; set; }
        public string PhoneUser { get; set; } = null!;
        public int RoleUser { get; set; }
        public int? DepartmentUser { get; set; }
        public string? LoginUser { get; set; }
        public string? PasswordUser { get; set; }

        public virtual Department? DepartmentUserNavigation { get; set; }
        public virtual Role RoleUserNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SilverRequest> SilverRequests { get; set; }
    }
}
