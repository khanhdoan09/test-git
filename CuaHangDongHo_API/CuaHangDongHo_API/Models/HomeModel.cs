using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaHangDongHo_API.Models
{
    public class HomeModel
    {
        public IEnumerable<product> productByNewArrival { get; set; }
        public IEnumerable<product> productsByBestSeller { get; set; }
    }
}