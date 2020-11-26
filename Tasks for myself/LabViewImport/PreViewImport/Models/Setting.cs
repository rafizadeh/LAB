using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PreViewImport.Models
{
    public class Setting
    {
        public int Id { get; set; }

        public string Logo { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        public string Facebook { get; set; }

        public string Linkedin { get; set; }

        public string Slogan { get; set; }

        public string Lat { get; set; }

        public string Long { get; set; }

        public DateTime OpeningHours { get; set; }

        public DateTime ClosingHours { get; set; }
    }
}