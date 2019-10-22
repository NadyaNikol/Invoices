﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class Sex
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NameSex { get; set; }
    }
}
