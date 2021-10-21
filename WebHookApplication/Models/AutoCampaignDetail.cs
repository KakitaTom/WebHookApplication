using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoCampaignDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }
        public int CampaignId { get; set; }
        public byte? Status { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public int? ContactId { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string ErrorMessage { get; set; }
        public int? OrderId { get; set; }
        public int? OrderProductId { get; set; }
        public DateTime? DateUpdateStatus { get; set; }
        public DateTime? DateOpen { get; set; }
        public DateTime? DateClick { get; set; }
        public DateTime? DateSendExpected { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool? IsAutomate { get; set; }
        public string PostLink { get; set; }
    }
}
