using System;
using System.Collections.Generic;

#nullable disable

namespace WebHookApplication.Models
{
    public partial class DeaActivity
    {
        public byte Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
