using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class PricePerMessage
    {
        public int Id { get; set; }
        public string SendingType { get; set; }
        public decimal? Price { get; set; }
        public bool? IsActive { get; set; }
    }
}
