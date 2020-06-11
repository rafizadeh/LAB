using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _11062020.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        [Required, MinLength(100)]
        public string Description { get; set; }

        public List<ServicePhoto> ServicePhotos { get; set; }
    }
}
