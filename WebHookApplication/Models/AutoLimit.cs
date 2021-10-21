using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoLimit
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public string CampaignAction { get; set; }
        public int? LimitCount { get; set; }
    }
}
