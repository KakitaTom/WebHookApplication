using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AccDeposit
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Describe { get; set; }
        public decimal? MoneyDeposit { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateDeposit { get; set; }
        public int? StaffCreateId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsUser { get; set; }
        public bool? IsSoftWare { get; set; }
        public bool? IsSmsApi { get; set; }
        public string PaymentCode { get; set; }
        public decimal? Balance { get; set; }
        public string ShopType { get; set; }
        public decimal? AmountUsed { get; set; }
        public int? TotalMessage { get; set; }
        public int? SentMessage { get; set; }
        public int? LeftMessage { get; set; }
    }
}
