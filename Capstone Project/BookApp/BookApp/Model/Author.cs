﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookService.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string biography { get; set; }
    }
}
