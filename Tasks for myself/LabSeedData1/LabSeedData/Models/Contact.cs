using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabSeedData.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public string Number { get; set; }

        public string Message { get; set; }
    }
}
