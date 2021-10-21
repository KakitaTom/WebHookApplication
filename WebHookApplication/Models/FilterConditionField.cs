using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class FilterConditionField
    {
        public int Id { get; set; }
        public string FieldId { get; set; }
        public string ConditionId { get; set; }
        public string Description { get; set; }

        public virtual FilterCondition Condition { get; set; }
        public virtual FilterField Field { get; set; }
    }
}
