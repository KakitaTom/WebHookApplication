using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class staff
    {
        public staff()
        {
            Companies = new HashSet<Company>();
            Deals = new HashSet<Deal>();
            Orders = new HashSet<Order>();
            StaffRoles = new HashSet<StaffRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsLock { get; set; }
        public int? StaffCreateId { get; set; }
        public bool? IsSystem { get; set; }
        public int? AccountId { get; set; }
        public string UserKey { get; set; }
        public string MacAdress { get; set; }
        public int? SleepLoadData { get; set; }
        public int? TimeStopErrorZalo { get; set; }
        public int? TimeStopErrorFacebook { get; set; }
        public int? TimeStopErrorShopee { get; set; }
        public int? MaxThread { get; set; }
        public int? TimeSleepByStepZalo { get; set; }
        public int? TimeSleepByStepFacebook { get; set; }
        public int? CountAnUnknownError { get; set; }
        public bool? IsDisplayedRunning { get; set; }
        public bool? IsNotificationFacebook { get; set; }
        public string KeyMac { get; set; }
        public string MacMobile { get; set; }
        public bool? IsSeeding { get; set; }
        public int? SeedingHourFrom { get; set; }
        public int? SeedingHourTo { get; set; }
        public string SeedingDayType { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<StaffRole> StaffRoles { get; set; }
    }
}
