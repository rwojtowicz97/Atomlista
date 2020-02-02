using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Atomlista.Models
{
    public class Team
    {
        [Key]
        public int Id { get; protected set; }
        [Required]
        [MaxLength(50)]
        public string TeamName { get; protected set; }
        public List<Person> People { get; protected set; } = new List<Person>();
    }
}
