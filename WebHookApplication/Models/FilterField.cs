using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class FilterField
    {
        public FilterField()
        {
            FilterConditionFields = new HashSet<FilterConditionField>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public bool? IsFilterCustomer { get; set; }
        public bool? IsFilterTrigger { get; set; }
        public string DataType { get; set; }
        public string Url { get; set; }

        public virtual ICollection<FilterConditionField> FilterConditionFields { get; set; }
    }
}
