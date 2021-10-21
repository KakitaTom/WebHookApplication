using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
    }
}
