using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AkaBizSetting
    {
        public string FacebookVersion { get; set; }
        public int? CountCampaignDetailMax { get; set; }
        public int? PackageDemoDay { get; set; }
        public int? PackageMonthSms { get; set; }
        public int? PackageMonthZalo { get; set; }
        public int? PackageMonthFacebook { get; set; }
        public int? PackageMonthCombo { get; set; }
        public int? TimeOutScrollGetData { get; set; }
        public int? RandomLikeFeedFacebook { get; set; }
        public int? RandomCommentFeedFacebook { get; set; }
        public int? PackageFreeMaxShop { get; set; }
        public int? PackageFreeMaxActionInDay { get; set; }
        public bool? PackageFreeIsAutomate { get; set; }
        public int? ImportMax { get; set; }
        public int? MaxDataSmsDemo { get; set; }
    }
}
