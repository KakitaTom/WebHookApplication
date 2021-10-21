using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class CronLog
    {
        public int Id { get; set; }
        public string ShopeType { get; set; }
        public DateTime LatestTime { get; set; }
    }
}
