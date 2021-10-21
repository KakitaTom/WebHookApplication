using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class ShopConnectionType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AuthorityType { get; set; }
        public string LinkAuthority { get; set; }
    }
}
