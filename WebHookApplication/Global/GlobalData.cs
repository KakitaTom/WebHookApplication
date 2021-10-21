using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHookApplication.ViewModel;

namespace WebHookApplication.Global
{
    public static class GlobalData
    {
        public static int Pos { get; set; } = 0;
        public static List<ContactViewModel> Contacts { get; set; } = new List<ContactViewModel>();
        public static List<StaffViewModel> Staffs { get; set; } = new List<StaffViewModel>()
        {
            new StaffViewModel { Id = 1, Name = "Dung", KeyWord = "sms-email"},
            new StaffViewModel { Id = 2, Name = "Lam", KeyWord = "sms" },
            new StaffViewModel { Id = 3, Name = "Ha", KeyWord = "magazine" },
            new StaffViewModel { Id = 4, Name = "Quang"}
        };
        public static List<int> ChosenStaffs { get; set; } = new List<int>();
    }
}
