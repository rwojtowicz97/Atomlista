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
        public int Id { get; protected set; }
        public List<Atom> Atoms { get; protected set; } = new List<Atom>();
        public List<Product> Products { get; protected set; } = new List<Product>();
        [Required]
        public Person Person { get; protected set; }

    }
}
