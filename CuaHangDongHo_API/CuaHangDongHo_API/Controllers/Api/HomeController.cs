using CuaHangDongHo_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CuaHangDongHo_API.Controllers.Api
{
    public class HomeController : ApiController
    {
        DBWatch db = new DBWatch();
        public IHttpActionResult GetProducts()
        {
            IList<product> products = db.products.Take(20).ToList();
            return Ok(products);
        }
        //public IHttpActionResult GetProductByNewArrival(DateTime d)
        //{
        //    IList<product> products = db.products.OrderByDescending(p => (p.update_date- d)).Take(10).ToList();
        //    return Ok(products);
        //}
        public IHttpActionResult GetProductByBrand(string bid)
        {
            IList<product> products = db.products.Where(p=>p.brand_id.Equals(bid)).Take(5).ToList();
            return Ok(products);
        }
        public IHttpActionResult GetProductByGender(string gen)
        {
            IList<product> products = db.products.Where(p => p.gender.Equals(gen)).Take(5).ToList();
            return Ok(products);
        }
        public IHttpActionResult GetProductById(string pid)
        {
            product pi = db.products.Where(p => p.product_id.Equals(pid)).FirstOrDefault();
            return Ok(pi);
        }
    }
}
