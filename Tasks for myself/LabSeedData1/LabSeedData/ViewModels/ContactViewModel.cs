using LabSeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabSeedData.ViewModels
{
    public class ContactViewModel
    {
        public ContactViewModel()
        {

        }

        public ContactViewModel(AppDetail appDetail)
        {
            this.AppDetail = appDetail;
        }

        public ContactViewModel(AppDetail appDetail, Contact contact)
            :this(appDetail)
        {
            this.Contact = contact;
        }

        public Contact Contact { get; set; }

        public AppDetail AppDetail { get; set; }
    }
}
