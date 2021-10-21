using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class CusGroup
    {
        public CusGroup()
        {
            CusGroupDetails = new HashSet<CusGroupDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public int GroupFilterId { get; set; }

        public virtual ICollection<CusGroupDetail> CusGroupDetails { get; set; }
    }
}
