using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHookApplication.Global;
using WebHookApplication.Models;
using WebHookApplication.ViewModel;

namespace WebHookApplication.Service
{
    public class ContactService
    {
        private StaffService _staffService;

        public ContactService()
        {
            _staffService = new StaffService();
        }

        public int GetStaff()
        {
            using (var db = new akaBizAutoDbContext())
            {
                if (GlobalData.ChosenStaffs.Count == 0)
                {
                    GlobalData.ChosenStaffs = db.ConSplitData.Select(x => (int)x.StaffId).ToList();
                }

                if (GlobalData.Pos == GlobalData.ChosenStaffs.Count)
                {
                    GlobalData.Pos = 0;
                }

                var res = GlobalData.Pos;

                var pos = GlobalData.ChosenStaffs[res];

                GlobalData.Pos++;
                return pos;
            }
        }

        public StaffView GetStaffById(int id)
        {
            using (var db = new akaBizAutoDbContext())
            {
                var staff = db.staff.SingleOrDefault(x => x.Id == id);

                var result = new StaffView();
                result.Id = staff.Id;
                result.Name = staff.Name;
                return result;
            }
        }

        public int Add(ContactViewModel contactViewModel)
        {
            try
            {
                using (var db = new akaBizAutoDbContext())
                {
                    var contactInDB = db.Contacts.SingleOrDefault(x => x.ContactHubSpotId == contactViewModel.id.ToString());

                    if(contactInDB == null)
                    {
                        var pos = GetStaff();
                        var staff = GetStaffById(pos);

                        var contact = new Contact()
                        {
                            FirstName = contactViewModel.properties.firstname,
                            LastName = contactViewModel.properties.lastname,
                            Mobile = contactViewModel.properties.phone,
                            Email = contactViewModel.properties.email,
                            DateCreate = contactViewModel.createdAt,
                            DateModify = contactViewModel.updatedAt,
                            StaffOwnerId = staff.Id,
                            StaffOwnerName = staff.Name,
                            ContactHubSpotId = contactViewModel.id.ToString(),
                            Source = "hubspot"
                        };

                        db.Contacts.Add(contact);
                    }
                    else
                    {
                        contactInDB.FirstName = contactViewModel.properties.firstname;
                        contactInDB.LastName = contactViewModel.properties.lastname;
                        contactInDB.Mobile = contactViewModel.properties.phone;
                        contactInDB.Email = contactViewModel.properties.email;
                        contactInDB.DateCreate = contactViewModel.createdAt;
                        contactInDB.DateModify = contactViewModel.updatedAt;
                        contactInDB.StaffOwnerId = contactViewModel.staffOwnerId;
                        contactInDB.StaffOwnerName = contactViewModel.staffOwnerName;
                    }
                    db.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex);
                return -1;
            }
            
        }

        public ContactViewModel GetContactByHubId(string id)
        {
            using (var db = new akaBizAutoDbContext())
            {
                var contact = db.Contacts.SingleOrDefault(x => x.ContactHubSpotId == id);

                if (contact == null)
                {
                    return null;
                }

                var contactView = new ContactViewModel();
                contactView.properties = new Properties
                {
                    firstname = contact.FirstName,
                    lastname = contact.LastName,
                    phone = contact.Mobile,
                    email = contact.Email
                };
                contactView.staffOwnerId = contact.StaffOwnerId ?? 0;
                contactView.staffOwnerName = contact.StaffOwnerName ?? "";
                contactView.id = int.Parse(contact.ContactHubSpotId);

                return contactView;
            }

        }

        public int Edit(ContactViewModel contactViewModel)
        {
            using (var db = new akaBizAutoDbContext())
            {
                var contact = db.Contacts.SingleOrDefault(x => x.ContactHubSpotId == contactViewModel.id.ToString());

                if (contact == null)
                {
                    return -1;
                }

                contact.FirstName = contactViewModel.properties.firstname;
                contact.LastName = contactViewModel.properties.lastname;
                contact.Mobile = contactViewModel.properties.phone;
                contact.Email = contactViewModel.properties.email;
                contact.DateModify = contactViewModel.updatedAt;

                db.SaveChanges();
                return 0;
            }
        }
    }
}
