using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Deals = new HashSet<Deal>();
            Orders = new HashSet<Order>();
            SmsSendingContacts = new HashSet<SmsSendingContact>();
            TagContacts = new HashSet<TagContact>();
            TagTables = new HashSet<TagTable>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Cmnd { get; set; }
        public string ContactShopeeCode { get; set; }
        public string Vocative { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmailList { get; set; }
        public string Mobile { get; set; }
        public byte? Network { get; set; }
        public string MobileList { get; set; }
        public string Zalo { get; set; }
        public string CompanyName { get; set; }
        public DateTime? Birthday { get; set; }
        public byte? LifeCycle { get; set; }
        public byte? LeadStatus { get; set; }
        public string Describe { get; set; }
        public int? StaffOwnerId { get; set; }
        public string StaffOwnerName { get; set; }
        public int? StaffCreateId { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string Tag { get; set; }
        public string TagNameList { get; set; }
        public int? CompanyId { get; set; }
        public string Source { get; set; }
        public string Country { get; set; }
        public string Adress { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public short? SumSms { get; set; }
        public short? SumEmail { get; set; }
        public int? SumPoint { get; set; }
        public short? SumOrder { get; set; }
        public int? AccountId { get; set; }
        public bool? IsValidationEmail { get; set; }
        public bool? IsValidationMobile { get; set; }
        public int? SleepLoadData { get; set; }
        public bool? IsReceivedEmail { get; set; }
        public bool? IsReceivedSms { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public string Uid { get; set; }
        public short? PipeLineId { get; set; }
        public string StatusInCrm { get; set; }
        public short? ReasonId { get; set; }
        public byte? ActivityId { get; set; }
        public short? ResultId { get; set; }
        public DateTime? DateRequest { get; set; }
        public int? InducstryId { get; set; }
        public DateTime? DateNextWork { get; set; }
        public string KeyWordSplit { get; set; }
        public string ContentUpdateHubSpot { get; set; }
        public string OriginalSorce { get; set; }
        public string OriginalSorceDrillDown1 { get; set; }
        public string OriginalSorceDrillDown2 { get; set; }
        public string LastPageSeen { get; set; }
        public string FirstPageSeen { get; set; }
        public string LastReferringSite { get; set; }
        public string FirstReferringSite { get; set; }
        public string AverragePageviews { get; set; }
        public int? NumberOfFormSubmissions { get; set; }
        public string RecenConversion { get; set; }
        public DateTime? RecenConversionData { get; set; }
        public string ContactHubSpotId { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SmsSendingContact> SmsSendingContacts { get; set; }
        public virtual ICollection<TagContact> TagContacts { get; set; }
        public virtual ICollection<TagTable> TagTables { get; set; }
    }
}
