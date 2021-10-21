using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ConditionContact
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public int? StaffOwnerId { get; set; }
        public string TagListStringContain { get; set; }
        public string TagListStringNotContain { get; set; }
        public int? TagIdContain { get; set; }
        public int? TagIdNotContain { get; set; }
        public DateTime? DateOrderAfter { get; set; }
        public DateTime? DateOrderBefore { get; set; }
        public int? SumPointBigger { get; set; }
        public int? SumPointLess { get; set; }
        public short? SumOrderBigger { get; set; }
        public short? SumOrderLess { get; set; }
        public int? SendingId { get; set; }
        public int? TrigerId { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? StaffCreateId { get; set; }
        public int? AccountId { get; set; }
    }
}
