using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketConsoleApp
{
    public class DB : DbContext
    {
        public DbSet<Mahsulotlar> Mahsulotlar { get; set; }

        public DbSet<Ishchilar> Ishchilar { get; set; }

        public DbSet<Xaridlar> Xaridlar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer("server = (localdb)\\mssqllocaldb; database=SupermarketDB; Trusted_Connection = true;");
        }
    }
}
