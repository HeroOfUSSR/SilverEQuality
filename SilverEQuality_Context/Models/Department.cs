﻿using System;
using System.Collections.Generic;

namespace SilverEQuality_Context.Models
{
    public partial class Department
    {
        public Department()
        {
            Users = new HashSet<User>();
            Checks = new HashSet<Check>();
        }

        public int CodeDepartment { get; set; }
        public bool IsAtWorkDepartment { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Check> Checks { get; set; }

    }
}
