using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class DepositHistory
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public DateTime? DateCreate { get; set; }
        public decimal? Amount { get; set; }
        public string ShopType { get; set; }
    }
}
