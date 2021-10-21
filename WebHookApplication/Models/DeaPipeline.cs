using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class DeaPipeline
    {
        public DeaPipeline()
        {
            DealPipelines = new HashSet<Deal>();
            DealStages = new HashSet<Deal>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public short? ParentId { get; set; }
        public bool? IsPipeline { get; set; }
        public byte? IndexStage { get; set; }
        public string ColorStage { get; set; }
        public bool? IsStageClose { get; set; }
        public int? AccountId { get; set; }
        public byte? StatusId { get; set; }

        public virtual ICollection<Deal> DealPipelines { get; set; }
        public virtual ICollection<Deal> DealStages { get; set; }
    }
}
