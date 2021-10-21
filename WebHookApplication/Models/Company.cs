using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class Company
    {
        public Company()
        {
            Deals = new HashSet<Deal>();
            TagCompanies = new HashSet<TagCompany>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Industry { get; set; }
        public string LinkedIn { get; set; }
        public string Type { get; set; }
        public int? ContactId { get; set; }
        public string Adress { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public decimal? Revenue { get; set; }
        public int? ParentId { get; set; }
        public string Source { get; set; }
        public DateTime? DateModify { get; set; }
        public int? StaffOwner { get; set; }
        public int? StaffCreate { get; set; }
        public int? StaffModify { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Tag { get; set; }
        public int? AccountId { get; set; }

        public virtual staff StaffOwnerNavigation { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
        public virtual ICollection<TagCompany> TagCompanies { get; set; }
    }
}
