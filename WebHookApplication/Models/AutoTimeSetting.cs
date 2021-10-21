using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoTimeSetting
    {
        public int? TimeSleepBetween2From { get; set; }
        public int? TimeSleepBetween2To { get; set; }
        public int? CountPauseAfterSending { get; set; }
        public int? TimePauseAfterSending { get; set; }
        public int? TimePauseAfterError { get; set; }
        public int? CountSendingOfDay { get; set; }
        public string TypeAction { get; set; }
        public int? AccountId { get; set; }
        public int? StaffId { get; set; }
    }
}
