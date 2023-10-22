using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tifrea_Denisa_Amalia_Lab2._1.Models;

namespace Tifrea_Denisa_Amalia_Lab2._1.Data
{
    public class Tifrea_Denisa_Amalia_Lab2_1Context : DbContext
    {
        public Tifrea_Denisa_Amalia_Lab2_1Context (DbContextOptions<Tifrea_Denisa_Amalia_Lab2_1Context> options)
            : base(options)
        {
        }

        public DbSet<Tifrea_Denisa_Amalia_Lab2._1.Models.Book> Book { get; set; } = default!;

        public DbSet<Tifrea_Denisa_Amalia_Lab2._1.Models.Publisher>? Publisher { get; set; }
    }
}
