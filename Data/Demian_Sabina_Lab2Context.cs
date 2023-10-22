using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demian_Sabina_Lab2.Models;

namespace Demian_Sabina_Lab2.Data
{
    public class Demian_Sabina_Lab2Context : DbContext
    {
        public Demian_Sabina_Lab2Context (DbContextOptions<Demian_Sabina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Demian_Sabina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Demian_Sabina_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
