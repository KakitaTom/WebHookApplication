using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Tag
    {
        public Tag()
        {
            DealTags = new HashSet<DealTag>();
            TagCompanies = new HashSet<TagCompany>();
            TagContacts = new HashSet<TagContact>();
            TagTables = new HashSet<TagTable>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsSystem { get; set; }
        public int? AccountId { get; set; }
        public string Code { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<DealTag> DealTags { get; set; }
        public virtual ICollection<TagCompany> TagCompanies { get; set; }
        public virtual ICollection<TagContact> TagContacts { get; set; }
        public virtual ICollection<TagTable> TagTables { get; set; }
    }
}
