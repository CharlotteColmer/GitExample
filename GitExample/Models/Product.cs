﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitExample.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public string description { get; set; }

    }
}
