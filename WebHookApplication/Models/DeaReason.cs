using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class DeaReason
    {
        public DeaReason()
        {
            Deals = new HashSet<Deal>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Color { get; set; }
        public int? AccountId { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }
    }
}
