using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Atomlista.Models
{
    public class Person
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
