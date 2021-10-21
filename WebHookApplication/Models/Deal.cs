using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Deal
    {
        public Deal()
        {
            DeaHistories = new HashSet<DeaHistory>();
            DealTags = new HashSet<DealTag>();
            TagTables = new HashSet<TagTable>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ContactId { get; set; }
        public int? CompanyId { get; set; }
        public int? StaffOwnerId { get; set; }
        public decimal? Value { get; set; }
        public short? PipelineId { get; set; }
        public short? StageId { get; set; }
        public byte? SourceId { get; set; }
        public DateTime? DateClose { get; set; }
        public byte? StatusId { get; set; }
        public short? ReasonId { get; set; }
        public string Describe { get; set; }
        public byte? ActivityId { get; set; }
        public DateTime? DateAgain { get; set; }
        public int? StaffModifyId { get; set; }
        public DateTime? DateModify { get; set; }
        public int? StaffCreateId { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Tag { get; set; }
        public string TagNameList { get; set; }
        public int? StaffRequestId { get; set; }
        public DateTime? DateNextPlan { get; set; }
        public short? ResultId { get; set; }
        public DateTime? DateRequest { get; set; }
        public DateTime? DateRequestComplete { get; set; }
        public bool? IsPlan { get; set; }
        public int? AccountId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual DeaPipeline Pipeline { get; set; }
        public virtual DeaReason Reason { get; set; }
        public virtual staff StaffOwner { get; set; }
        public virtual DeaPipeline Stage { get; set; }
        public virtual ICollection<DeaHistory> DeaHistories { get; set; }
        public virtual ICollection<DealTag> DealTags { get; set; }
        public virtual ICollection<TagTable> TagTables { get; set; }
    }
}
