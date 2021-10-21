using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class FilterCondition
    {
        public FilterCondition()
        {
            FilterConditionFields = new HashSet<FilterConditionField>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FilterConditionField> FilterConditionFields { get; set; }
    }
}
