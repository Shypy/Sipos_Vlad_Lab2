using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sipos_Vlad_Lab2.Models;

namespace Sipos_Vlad_Lab2.Data
{
    public class Sipos_Vlad_Lab2Context : DbContext
    {
        public Sipos_Vlad_Lab2Context (DbContextOptions<Sipos_Vlad_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sipos_Vlad_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sipos_Vlad_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Sipos_Vlad_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Sipos_Vlad_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
