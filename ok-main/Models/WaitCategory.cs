﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NotUseAuto.Models
{
    public class WaitCategory
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
