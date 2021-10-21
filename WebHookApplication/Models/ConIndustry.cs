using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ConIndustry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AccountId { get; set; }
    }
}
