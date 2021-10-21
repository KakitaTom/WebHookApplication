using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoCampaign
    {
        public int Id { get; set; }
        public string TriggerType { get; set; }
        public bool? IsActiveAutomate { get; set; }
        public int? ParentId { get; set; }
        public int AccountId { get; set; }
        public int ShopId { get; set; }
        public string FanpageUid { get; set; }
        public string Name { get; set; }
        public string CampaignActionId { get; set; }
        public string ContentMessage { get; set; }
        public string Media { get; set; }
        public string Image { get; set; }
        public string FolderMedia { get; set; }
        public bool? IsSendFolderMedia { get; set; }
        public int? CountPost { get; set; }
        public string Status { get; set; }
        public DateTime? Schedule { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateEdit { get; set; }
        public int? CountSendingOfDay { get; set; }
        public int? TimeSleepBetween2 { get; set; }
        public bool? IsDisplayedRunning { get; set; }
        public int? ShopContactId { get; set; }
        public bool? IsInviteAllFriendsToGroup { get; set; }
        public int? StaffId { get; set; }
        public bool? TiengVietKhongDau { get; set; }
        public bool? IsAddFriend { get; set; }
        public bool? IsComment { get; set; }
        public string CommentContent { get; set; }
        public string CommentMedia { get; set; }
        public string EmailSubject { get; set; }
        public int? CountSuccess { get; set; }
        public int? CountFail { get; set; }
        public int? CountOpen { get; set; }
        public int? CountClick { get; set; }
        public bool? IsAutoGetContentPost { get; set; }
        public string LinkUidAutoGetContentPost { get; set; }
        public bool? IsCommentByKeywords { get; set; }
        public string Keywords { get; set; }
        public int? TimeMinuteScrollMax { get; set; }
        public bool? IsCommentByPage { get; set; }
        public bool? IsAutoGetImagePost { get; set; }
        public bool? IsSendAllFriends { get; set; }
        public bool? IsSendByTags { get; set; }
        public bool? IsSendByShareMethod { get; set; }
        public bool? IsSendByCount { get; set; }
        public bool? IsCheckClick { get; set; }
        public string Link { get; set; }

        public virtual Account Account { get; set; }
        public virtual AutoCampaignAction CampaignAction { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
