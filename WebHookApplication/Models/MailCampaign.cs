using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class MailCampaign
    {
        public MailCampaign()
        {
            CampaignDetails = new HashSet<CampaignDetail>();
            MailSendings = new HashSet<MailSending>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public byte? CampaignType { get; set; }
        public int? SendingFirstId { get; set; }
        public int? AccountId { get; set; }
        public DateTime? DateModify { get; set; }
        public int? StaffCreateId { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public int? CountSended { get; set; }
        public int? CountRecieved { get; set; }
        public int? CountOpened { get; set; }
        public int? CountClicked { get; set; }
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
        public int? TagIdContain { get; set; }
        public int? TagIdNotContain { get; set; }
        public short? PipelineId { get; set; }

        public virtual ICollection<CampaignDetail> CampaignDetails { get; set; }
        public virtual ICollection<MailSending> MailSendings { get; set; }
    }
}
