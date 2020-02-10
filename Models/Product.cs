using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Atomlista.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Atom> Atoms { get; set; } = new List<Atom>();
        public Person BussinessOwner { get; set; }
        public Person TechOwner { get; set; }
    }
}
