using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class CampaignDetail
    {
        public int Id { get; set; }
        public byte? ActionType { get; set; }
        public int? ActionValue { get; set; }
        public short? DayDelayAfterAction { get; set; }
        public TimeSpan? ActionTimeOfDay { get; set; }
        public int? ParentId { get; set; }
        public string ActionCondition { get; set; }
        public int? CampaignId { get; set; }
        public DateTime? DateModify { get; set; }
        public int StaffCreateId { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateCreate { get; set; }

        public virtual MailCampaign Campaign { get; set; }
    }
}
