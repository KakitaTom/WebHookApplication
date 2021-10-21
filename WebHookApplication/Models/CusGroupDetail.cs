using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class CusGroupDetail
    {
        public int Id { get; set; }
        public int CusGroupId { get; set; }
        public int ContactId { get; set; }
        public DateTime? DateCreate { get; set; }

        public virtual CusGroup CusGroup { get; set; }
    }
}
