using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Shop
    {
        public Shop()
        {
            AutoCampaigns = new HashSet<AutoCampaign>();
            AutoShopContacts = new HashSet<AutoShopContact>();
        }

        public int Id { get; set; }
        public string AuthCode { get; set; }
        public int? StaffId { get; set; }
        public bool? IsActivity { get; set; }
        public int AccountId { get; set; }
        public string Phone { get; set; }
        public string ShopName { get; set; }
        public string ShopType { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateCreateRefreshToken { get; set; }
        public string AccessToken { get; set; }
        public DateTime? DateCreateAccessToken { get; set; }
        public DateTime? DateCreateAuthCode { get; set; }
        public string AppId { get; set; }
        public int? ShopeeShopId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AppKey { get; set; }
        public bool? IsDisplayedLogin { get; set; }
        public bool? IsDisplayedLoadData { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsDisplayedStart { get; set; }
        public string ProfileFolderName { get; set; }
        public string PathProfileChrome { get; set; }
        public string Proxy { get; set; }
        public bool? IsBrowser { get; set; }
        public bool? IsDelete { get; set; }
        public string ServerName { get; set; }
        public string Email { get; set; }
        public int? Port { get; set; }
        public bool? IsSsl { get; set; }
        public bool? IsSeeding { get; set; }
        public bool? IsDisplayedRunningAutomate { get; set; }
        public bool? IsDisplayedBrowser { get; set; }
        public bool? IsOnlyOpenBrowserWhenRunning { get; set; }

        public virtual Account Account { get; set; }
        public virtual AutoShopCategory Category { get; set; }
        public virtual ICollection<AutoCampaign> AutoCampaigns { get; set; }
        public virtual ICollection<AutoShopContact> AutoShopContacts { get; set; }
    }
}
