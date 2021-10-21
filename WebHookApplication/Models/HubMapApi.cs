using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class HubMapApi
    {
        public int Id { get; set; }
        public string SubscriptionType { get; set; }
        public string TagCode { get; set; }
        public string HubspotValue { get; set; }
    }
}
