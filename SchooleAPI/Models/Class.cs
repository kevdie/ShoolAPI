﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchooleAPI.Models
{
    public class Class
    {
        public int IdClass { get; set; }
        [Required]
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List <Student> students { get; set; }
        
    }
}
