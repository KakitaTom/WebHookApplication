using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class TagContact
    {
        public int Id { get; set; }
        public int? TagId { get; set; }
        public int? ContactId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
