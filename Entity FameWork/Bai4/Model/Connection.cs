using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Bai4.Model
{
    class Connection:DbContext
    {
        public DbSet<LoaiNguyenLieu> LoaiNguyenLieus { get; set; }
        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }
        public DbSet<PhieuThu> PhieuThus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer(@"Server = DESKTOP-7MQ60DF; Database = Bai4;
                    Integrated Security= true");
        }
    }
}
