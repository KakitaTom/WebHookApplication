using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class DeaHistory
    {
        public int Id { get; set; }
        public int? DealsId { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Describe { get; set; }
        public string ActivityId { get; set; }
        public int? StaffCreateId { get; set; }
        public short? StageOldId { get; set; }
        public short? StageNewId { get; set; }
        public short? PipelineOldId { get; set; }
        public short? PipelineNewId { get; set; }
        public short? ResultId { get; set; }
        public int? StaffRequestId { get; set; }
        public DateTime? DateRequest { get; set; }
        public DateTime? DateRequestComplete { get; set; }
        public int? StaffRequestCompleteId { get; set; }
        public int? ContactId { get; set; }

        public virtual Deal Deals { get; set; }
    }
}
