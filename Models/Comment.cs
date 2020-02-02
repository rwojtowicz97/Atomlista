using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Atomlista.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; protected set; }
        [Required]
        [MaxLength(200)]
        public string CommentBody { get; protected set; }
        [Required]
        [Column(TypeName ="datetime")]
        public DateTime CreatedAt { get; protected set; }
        [Required]
        public Product CommentedProduct { get; protected set; }

    }
}
