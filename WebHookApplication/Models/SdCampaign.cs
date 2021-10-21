using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class SdCampaign
    {
        public int Id { get; set; }
        public string ActionId { get; set; }
        public string FacebookType { get; set; }
        public string FacebookActionType { get; set; }
        public int? Quantity { get; set; }
        public int? PostInDay { get; set; }
        public string TimeDivision { get; set; }
        public string TimeType { get; set; }
        public DateTime? TimeAction { get; set; }
        public string Message { get; set; }
        public string Uid { get; set; }
        public bool? IsComment { get; set; }
        public int? CommentAfterMinute { get; set; }
        public int? CommentQuantity { get; set; }
        public string CommentTimeDivision { get; set; }
        public string CommentMessage { get; set; }
        public bool? IsActive { get; set; }

        public virtual SdAction Action { get; set; }
        public virtual SdFacebookActionType FacebookActionTypeNavigation { get; set; }
        public virtual SdFacebookType FacebookTypeNavigation { get; set; }
        public virtual SdTimeDivision TimeDivisionNavigation { get; set; }
        public virtual SdTimeType TimeTypeNavigation { get; set; }
    }
}
