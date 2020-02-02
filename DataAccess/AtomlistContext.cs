using Atomlista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Atomlista.DataAccess
{
    public class AtomlistContext : DbContext
    {
        public AtomlistContext(DbContextOptions options) : base(options) { }
        public DbSet<Atom> Atoms { get; set; }
        public DbSet<BusinessOwner> BusinessOwners { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TechOwner> TechOwners { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
