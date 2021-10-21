using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ConSplitDatum
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public string KeyWordSplit { get; set; }
        public int? SplitRatio { get; set; }
        public int? AccountId { get; set; }
        public int? MaxContactInDay { get; set; }
    }
}
