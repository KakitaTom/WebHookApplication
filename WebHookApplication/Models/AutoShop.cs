using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoShop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccountId { get; set; }
        public string Proxy { get; set; }
        public string PathProfileChrome { get; set; }
        public string ProfileFolderName { get; set; }
        public string Ten { get; set; }
        public string Ho { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? DateOfBirth { get; set; }
        public int? MonthOfBirth { get; set; }
        public int? YearOfBirth { get; set; }
        public bool? IsFemale { get; set; }
        public bool? IsDisplayedStart { get; set; }
        public bool? IsActive { get; set; }
        public int? ShopCategoryId { get; set; }
        public bool? IsDisplayedLogin { get; set; }
        public bool? IsDisplayedLoadData { get; set; }
    }
}
