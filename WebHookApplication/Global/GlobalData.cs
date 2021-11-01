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
        public static List<int> ChosenStaffs { get; set; } = new List<int>();
    }
}
