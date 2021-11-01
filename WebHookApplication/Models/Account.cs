using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Account
    {
        public Account()
        {
            AutoCampaigns = new HashSet<AutoCampaign>();
            AutoShopCategories = new HashSet<AutoShopCategory>();
            MailMessageSms = new HashSet<MailMessageSm>();
            ProductVariants = new HashSet<ProductVariant>();
            Shops = new HashSet<Shop>();
        }

        public int Id { get; set; }
        public string LoginKey { get; set; }
        public string ApiKey { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactMobile { get; set; }
        public string ContactAdress { get; set; }
        public string Source { get; set; }
        public string EmployeeSize { get; set; }
        public string OrderSize { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateExpiration { get; set; }
        public byte? AccountType { get; set; }
        public string StoreName { get; set; }
        public string ZaloSocial { get; set; }
        public string StoreAddress { get; set; }
        public string StoreHotline { get; set; }
        public string StoreZalo { get; set; }
        public string StoreShopee { get; set; }
        public string StoreLazada { get; set; }
        public string StorePage { get; set; }
        public string StoreLinkMessage { get; set; }
        public string StoreWeb { get; set; }
        public string StoreSendo { get; set; }
        public bool? IsDevice { get; set; }
        public int? MaxSmsOfMonth { get; set; }
        public int? MaxSmsOfDay { get; set; }
        public int? MaxEmailOfMonth { get; set; }
        public string ProductIdListString { get; set; }
        public byte? CategoryId { get; set; }
        public byte? CategorySendSmsId { get; set; }
        public int? SumSmsApiSend { get; set; }
        public decimal? SumMoneyDepositSmsApi { get; set; }
        public decimal? SumMoneyRestSmsApi { get; set; }
        public int? SumSmsApiRest { get; set; }
        public bool? IsUsb3G { get; set; }
        public int? SumSmsDcomSend { get; set; }
        public int? SumSmsSend { get; set; }
        public bool? IsActive { get; set; }
        public int? MaxSumDcomSend { get; set; }
        public bool? IsDemo { get; set; }
        public bool? IsEmail { get; set; }
        public string KeyMac { get; set; }
        public int? HeSoNhan { get; set; }
        public bool? IsFast { get; set; }
        public string Pass { get; set; }
        public bool? IsDaiLy { get; set; }
        public int? IddaiLy { get; set; }
        public int? SleepLoadData { get; set; }
        public bool? IsMobile { get; set; }
        public string MacMobile { get; set; }
        public bool? IsShowBrowser { get; set; }
        public string TypeString { get; set; }
        public string AccountCode { get; set; }
        public string EmailRecievedSmsReply { get; set; }
        public string EmailContactSub { get; set; }
        public string MacAdress { get; set; }
        public int? TimeStopErrorZalo { get; set; }
        public int? MaxThreed { get; set; }
        public int? TimeStopErrorFacebook { get; set; }
        public int? TimeStopErrorShopee { get; set; }
        public int? TimeSleepByStepZalo { get; set; }
        public int? TimeSleepByStepFacebook { get; set; }
        public int? CountAnUnknownError { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsDisplayedRunning { get; set; }
        public int? AddDayDemoOfDaiLy { get; set; }
        public int? AddDayUsingOfDaiLy { get; set; }
        public string DaiLyCode { get; set; }
        public string Career { get; set; }
        public bool? IsNotificationFacebook { get; set; }
        public int? StaffManageId { get; set; }
        public string AccountPackage { get; set; }
        public int? ContactId { get; set; }
        public decimal? Money { get; set; }
        public bool? IsConvert { get; set; }
        public int? MaxStaff { get; set; }

        public virtual ICollection<AutoCampaign> AutoCampaigns { get; set; }
        public virtual ICollection<AutoShopCategory> AutoShopCategories { get; set; }
        public virtual ICollection<MailMessageSm> MailMessageSms { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
