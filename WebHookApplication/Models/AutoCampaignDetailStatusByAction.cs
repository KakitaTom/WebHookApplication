using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoCampaignDetailStatusByAction
    {
        public string CampaignActionId { get; set; }
        public byte Status { get; set; }
    }
}
