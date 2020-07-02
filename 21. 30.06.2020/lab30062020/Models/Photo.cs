﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab30062020.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [NotMapped, Required]
        public IFormFile[] files { get; set; }
    }
}
