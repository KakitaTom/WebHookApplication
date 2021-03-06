using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class SdAction
    {
        public SdAction()
        {
            SdCampaigns = new HashSet<SdCampaign>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SdCampaign> SdCampaigns { get; set; }
    }
}
