using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Atomlista.Models
{
    public class TechOwner
    {
        [Key]
        public int Id { get; set; }
        public List<Atom> Atoms { get; set; } = new List<Atom>();
        public List<Product> Products { get; set; } = new List<Product>();
        [Required]
        public Person Person { get; set; }

    }
}
