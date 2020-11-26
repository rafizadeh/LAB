using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _11062020.Models
{
    public class ServicePhoto
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Path { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; }
    }
}
