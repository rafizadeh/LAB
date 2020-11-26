using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PreViewImport.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required, MinLength(300)]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public List<Doctor> Doctors { get; set; }

    }
}