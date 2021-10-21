using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoCampaignAction
    {
        public AutoCampaignAction()
        {
            AutoAutomates = new HashSet<AutoAutomate>();
            AutoCampaigns = new HashSet<AutoCampaign>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string ShopType { get; set; }
        public bool? IsActive { get; set; }
        public int? TimePauseAfterError { get; set; }
        public bool? IsShowAutomate { get; set; }
        public bool? IsShowCustomer { get; set; }
        public bool? IsShowEcomAutoCondition { get; set; }
        public bool? IsShowLimit { get; set; }

        public virtual ICollection<AutoAutomate> AutoAutomates { get; set; }
        public virtual ICollection<AutoCampaign> AutoCampaigns { get; set; }
    }
}
