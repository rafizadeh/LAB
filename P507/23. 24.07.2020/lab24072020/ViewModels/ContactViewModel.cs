using lab24072020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab24072020.ViewModels
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
            //this.AppDetail = appDetail;
            this.Contact = contact;
        }

        public AppDetail AppDetail { get; set; }

        public Contact Contact { get; set; }
    }
}
