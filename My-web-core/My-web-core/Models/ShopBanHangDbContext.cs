using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_web_core.Models
{
    public class ShopBanHangDbContext:DbContext
    {

        public ShopBanHangDbContext()
        { }
        public ShopBanHangDbContext(DbContextOptions<ShopBanHangDbContext> options) : base(options)
        {

        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<NhaCC> NhaCCs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-7MQ60DF\\SQLEXPRESS01; Database = CarShop;Integrated Security= true");
        }
    }
}
