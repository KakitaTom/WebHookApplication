using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoAutomate
    {
        public int Id { get; set; }
        public int? IndexNumber { get; set; }
        public string CampaignActionId { get; set; }
        public int? TimeMinuteRun { get; set; }
        public int ShopCategoryId { get; set; }
        public int? CountRun { get; set; }
        public bool? IsDisplayedRunning { get; set; }
        public int? RandomLikeFeedFacebook { get; set; }
        public int? RandomCommentFeedFacebook { get; set; }

        public virtual AutoCampaignAction CampaignAction { get; set; }
        public virtual AutoShopCategory ShopCategory { get; set; }
    }
}
