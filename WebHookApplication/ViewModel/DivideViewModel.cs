using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebHookApplication.Models;

namespace WebHookApplication.ViewModel
{
    public class DivideViewModel
    {
        public List<SelectListItem> ListStaff { get; set; }
        public List<int> ListStaffId { get; set; }
        public string KeyWord { get; set; }
    }
}
