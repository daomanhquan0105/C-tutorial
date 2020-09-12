using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_web_core.Models;

namespace My_web_core.Controllers
{
    [Route("api/SanPham")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        [HttpGet]
        public List<SanPham> DSSanPham()
        {
            using(var db=new ShopBanHangDbContext())
            {
                List<SanPham> dsSP = db.SanPhams.ToList();
                return dsSP;
            }
        }
    }
}
