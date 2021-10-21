using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class FilterCustomer
    {
        public int Id { get; set; }
        public string OnValue { get; set; }
        public string FieldId { get; set; }
        public string ConditionId { get; set; }
        public int GroupId { get; set; }
        public bool? IsOrderFilter { get; set; }
        public bool? IsCustomerFilter { get; set; }

        public virtual FilterGroup Group { get; set; }
    }
}
