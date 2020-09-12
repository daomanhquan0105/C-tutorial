using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Bai3.Model
{
    class Connection:DbContext
    {
        public DbSet<HocVien> HocViens { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<NgayHoc> NgayHocs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer(@"Server = DESKTOP-7MQ60DF; Database = Bai3;
                    Integrated Security= true");
        }
    }
}
