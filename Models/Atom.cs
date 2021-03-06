﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Atomlista.Models
{
    public class Atom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string AtomName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Url { get; set; }
        public Person BussinessOwner { get; set; }
        public Person TechOwner { get; set; }
    }
}
