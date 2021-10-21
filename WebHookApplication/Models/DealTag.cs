using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class DealTag
    {
        public short Id { get; set; }
        public int? DealsId { get; set; }
        public int? TagId { get; set; }

        public virtual Deal Deals { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
