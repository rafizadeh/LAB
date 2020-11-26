using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxCrud.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}