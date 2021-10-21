using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class StaffRole
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? RoleId { get; set; }
        public bool? IsManager { get; set; }

        public virtual Role Role { get; set; }
        public virtual staff Staff { get; set; }
    }
}
