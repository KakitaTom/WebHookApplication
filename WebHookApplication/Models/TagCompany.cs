using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class TagCompany
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? TagId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
