using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailSending
    {
        public MailSending()
        {
            Conditions = new HashSet<Condition>();
            InverseParent = new HashSet<MailSending>();
            MailSendingConfigSmtps = new HashSet<MailSendingConfigSmtp>();
            MailTriggers = new HashSet<MailTrigger>();
        }

        public int Id { get; set; }
        public byte? Number { get; set; }
        public int? CampaignId { get; set; }
        public int? ConditionContactId { get; set; }
        public string Type { get; set; }
        public byte? CategoryId { get; set; }
        public string Event { get; set; }
        public string EventType { get; set; }
        public byte? SmsType { get; set; }
        public int? ConfigEmailId { get; set; }
        public string Title { get; set; }
        public string ContentMail { get; set; }
        public string Link { get; set; }
        public DateTime? DateSendExpected { get; set; }
        public bool? IsActivity { get; set; }
        public int StaffCreateId { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string Bcc { get; set; }
        public string Cc { get; set; }
        public string Replyto { get; set; }
        public int? ParentId { get; set; }
        public bool? IsTimeSendingNow { get; set; }
        public short? DayDelayAfterContactAction { get; set; }
        public short? HouseDelayAfterContactAction { get; set; }
        public TimeSpan? TimeSending { get; set; }
        public string ActionTypeContact { get; set; }
        public int? TagIdAdd { get; set; }
        public int? TagIdRemove { get; set; }
        public string TagIdListStringAdd { get; set; }
        public int? Points { get; set; }
        public string TagIdListStringRemove { get; set; }
        public int? AccountId { get; set; }
        public string ConfigListId { get; set; }
        public bool? IsSendingFirstOfCampaign { get; set; }
        public string IndexNo { get; set; }
        public short? SendingContactStatus { get; set; }
        public string ContactSource { get; set; }
        public int? ContacStaffOwnerId { get; set; }
        public string TagIdListStringContain { get; set; }
        public string TagIdListStringNotContain { get; set; }
        public int? TagIdContain { get; set; }
        public int? TagIdNotContain { get; set; }
        public DateTime? DateOrderAfter { get; set; }
        public DateTime? DateOrderBefore { get; set; }
        public int? SumPointBigger { get; set; }
        public int? SumPointLess { get; set; }
        public short? SumOrderBigger { get; set; }
        public short? SumOrderLess { get; set; }
        public int? ShopId { get; set; }
        public string LinkImage { get; set; }
        public bool? IsSystem { get; set; }
        public int? FileDetailId { get; set; }
        public bool? IsUnicode { get; set; }
        public int? ContentTemplateId { get; set; }
        public int? PipelineId { get; set; }

        public virtual MailCampaign Campaign { get; set; }
        public virtual MailSending Parent { get; set; }
        public virtual ICollection<Condition> Conditions { get; set; }
        public virtual ICollection<MailSending> InverseParent { get; set; }
        public virtual ICollection<MailSendingConfigSmtp> MailSendingConfigSmtps { get; set; }
        public virtual ICollection<MailTrigger> MailTriggers { get; set; }
    }
}
