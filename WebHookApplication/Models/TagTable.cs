using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class TagTable
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public int? DealId { get; set; }
        public int? OrderId { get; set; }
        public int? TagId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Deal Deal { get; set; }
        public virtual Order Order { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
