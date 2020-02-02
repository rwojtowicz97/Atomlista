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
        public int Id { get; protected set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; protected set; }
        [Required]
        [Column(TypeName ="datetime")]
        public DateTime CreatedAt { get; protected set; }
        public List<Comment> Comments { get; protected set; } = new List<Comment>();
        public List<Atom> Atoms { get; protected set; } = new List<Atom>();
    }
}
