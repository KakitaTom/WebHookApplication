using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class AutoGetDataType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string ShopType { get; set; }
    }
}
