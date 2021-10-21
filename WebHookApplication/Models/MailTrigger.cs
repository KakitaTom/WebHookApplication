using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailTrigger
    {
        public int Id { get; set; }
        public byte? TriggerType { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public DateTime? DateSend { get; set; }
        public int? TagIdAdd { get; set; }
        public int? TagIdRemove { get; set; }
        public int? SendingId { get; set; }
        public int StaffCreateId { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public int? AccountId { get; set; }
        public bool? IsActivity { get; set; }
        public byte? CommentRatingStar { get; set; }
        public bool? IsCreateSendingContact { get; set; }
        public int? TagIdContain { get; set; }
        public int? TagIdNotContain { get; set; }
        public DateTime? DateOrderAfter { get; set; }
        public DateTime? DateOrderBefore { get; set; }
        public int? SumPointBigger { get; set; }
        public int? SumPointLess { get; set; }
        public short? SumOrderBigger { get; set; }
        public short? SumOrderLess { get; set; }
        public DateTime? DateCreateContactAfter { get; set; }
        public DateTime? DateCreateContactBefore { get; set; }
        public int? FilterGroupContactId { get; set; }
        public int? FilterGroupOrderId { get; set; }
        public int? KeywordId { get; set; }
        public int? CountSended { get; set; }
        public int? CountRecieved { get; set; }
        public int? CountOpened { get; set; }
        public int? CountClicked { get; set; }
        public string PhoneNumberReceived { get; set; }
        public int? ShopId { get; set; }
        public bool? IsActiveShopee { get; set; }
        public string MessageZalo { get; set; }
        public bool? IsActiveZalo { get; set; }
        public string MessageSms { get; set; }
        public bool? IsActiveSms { get; set; }
        public int? ShopIdZalo { get; set; }
        public bool? InviteZalo { get; set; }
        public int? ShopIdSms { get; set; }
        public int? ShopIdFacebook { get; set; }
        public bool? InviteFacebook { get; set; }
        public string MessageFacebook { get; set; }
        public bool? IsActiveFacebook { get; set; }
        public string LinkMedia { get; set; }
        public int? DeleyTime { get; set; }
        public string DeleyType { get; set; }
        public short? PipelineId { get; set; }
        public int? AutoCampaignIdCheck { get; set; }
        public byte? StatusAutoCampaignCheck { get; set; }
        public int? AutoCampaignIdActive { get; set; }
        public int? StaffOwnerId { get; set; }

        public virtual Keyword Keyword { get; set; }
        public virtual MailSending Sending { get; set; }
    }
}
