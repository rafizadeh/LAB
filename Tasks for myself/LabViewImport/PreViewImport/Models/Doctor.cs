using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PreViewImport.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Fullname { get; set; }

        [Required]
        [StringLength(150)]
        public string Photo { get; set; }

        [Required, MinLength(400)]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Slug { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public string Facebook { get; set; }

        public string Linkedin { get; set; }

        public string Twitter { get; set; }

        public string Speciality { get; set; }

        public string ExpertIn { get; set; }

        public string Degree { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}