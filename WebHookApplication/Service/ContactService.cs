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

        public int GetStaff()
        {
            if (GlobalData.ChosenStaffs.Count == 0)
            {
                GlobalData.ChosenStaffs = GlobalData.Staffs.Select(x => x.Id).ToList();
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

        public int Add(ContactViewModel contactViewModel)
        {
            try
            {
                using (var db = new akaBizAutoDbContext())
                {
                    var contact = new Contact()
                    {
                        FirstName = contactViewModel.properties.firstname,
                        LastName = contactViewModel.properties.lastname,
                        Mobile = contactViewModel.properties.phone,
                        Email = contactViewModel.properties.email,
                        DateCreate = contactViewModel.createdAt,
                        DateModify = contactViewModel.updatedAt,
                        StaffOwnerId = contactViewModel.staffOwnerId,
                        StaffOwnerName = contactViewModel.staffOwnerName,
                        ContactHubSpotId = contactViewModel.id.ToString()
                    };

                    db.Contacts.Add(contact);
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
