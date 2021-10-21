using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class FilterGroup
    {
        public FilterGroup()
        {
            FilterCustomers = new HashSet<FilterCustomer>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public int AccountId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Operation { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<FilterCustomer> FilterCustomers { get; set; }
    }
}
