using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Bai1.Model
{
    class BusinessContext:DbContext
    {
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer(@"Server = DESKTOP-7MQ60DF; Database = Bai1;
                    Integrated Security= true");
        }
    }
}
