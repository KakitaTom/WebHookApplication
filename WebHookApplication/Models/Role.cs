using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Role
    {
        public Role()
        {
            StaffRoles = new HashSet<StaffRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public int? ParentId { get; set; }
        public bool? IsSystem { get; set; }
        public int? AccountId { get; set; }

        public virtual ICollection<StaffRole> StaffRoles { get; set; }
    }
}
