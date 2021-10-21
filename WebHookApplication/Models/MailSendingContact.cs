using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailSendingContact
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public int? DealsId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? SendingId { get; set; }
        public string SendingType { get; set; }
        public bool? SendingIsActivity { get; set; }
        public string ContactName { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public string SendingTitle { get; set; }
        public int? OrderProductId { get; set; }
        public int? TriggerId { get; set; }
        public int? CampaignId { get; set; }
        public DateTime? DateSendExpected { get; set; }
        public DateTime? DateSend { get; set; }
        public short? Status { get; set; }
        public short? Error { get; set; }
        public string DeviceMobile { get; set; }
        public int? DeviceId { get; set; }
        public int? ConfigSmtpId { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? StaffCreateId { get; set; }
        public DateTime? DateActionContact { get; set; }
        public DateTime? DateOpen { get; set; }
        public DateTime? DateClick { get; set; }
        public DateTime? DateReply { get; set; }
        public DateTime? DateReceived { get; set; }
        public string ActionTypeContact { get; set; }
        public string Message { get; set; }
        public string MessageReply { get; set; }
        public byte? Type { get; set; }
        public int? AccountId { get; set; }
        public bool? IsUnicode { get; set; }
        public byte? CountSms { get; set; }
        public string Link { get; set; }
        public string OrderCode { get; set; }
        public int? ShopId { get; set; }
        public byte? SendingCategoryId { get; set; }
        public string SendingEvent { get; set; }
        public string LinkImage { get; set; }
        public int? CommentId { get; set; }
        public int? NumberOfMessage { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? AutoCampaignDetailId { get; set; }
    }
}
