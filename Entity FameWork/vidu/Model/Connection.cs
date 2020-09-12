using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Bai2.Model
{
    class Connection:DbContext
    {
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DuAn> DuAns { get; set; }
        public DbSet<PhanCong> PhanCongs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer(@"Server = DESKTOP-7MQ60DF; Database = Bai2;
                    Integrated Security= true");
        }
    }
}
