using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Bai5.Model
{
    class Connection:DbContext
    {
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<LoaiMonAn> LoaiMonAns { get; set; }
        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<CongThuc> CongThucs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer(@"Server = DESKTOP-7MQ60DF; Database = Bai3;
                    Integrated Security= true");
        }
    }
}
