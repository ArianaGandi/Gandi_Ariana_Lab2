using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gandi_Ariana_Lab2.Models;

namespace Gandi_Ariana_Lab2.Data
{
    public class Gandi_Ariana_Lab2Context : DbContext
    {
        public Gandi_Ariana_Lab2Context (DbContextOptions<Gandi_Ariana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Gandi_Ariana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Gandi_Ariana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Gandi_Ariana_Lab2.Models.Author> Author { get; set; }
    }
}
