using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebHookApplication.Models;
using WebHookApplication.ViewModel;

namespace WebHookApplication.Service
{
    public class StaffService
    {
        public List<StaffView> GetSplitStaff()
        {
            using (var db = new akaBizAutoDbContext())
            {
                var result = from staff in db.staff
                    join
                        split in db.ConSplitData on staff.Id equals split.StaffId
                    select new StaffView()
                    {
                        Id = staff.Id,
                        Name = staff.Name,
                        KeyWord = split.KeyWordSplit
                        
                    };

                return result.ToList();
            }
        }
    }
}
