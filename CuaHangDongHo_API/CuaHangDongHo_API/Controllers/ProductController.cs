using CuaHangDongHo_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDongHo_API.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        DBWatch db = new DBWatch();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Brand(string bid)
        {

            IEnumerable<product> products = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var rs = client.GetAsync("home?bid=" + bid);
                rs.Wait();
                var re = rs.Result;
                if (re.IsSuccessStatusCode)
                {
                    var readRe = re.Content.ReadAsAsync<IList<product>>();
                    readRe.Wait();
                    products = readRe.Result;
                }

            }

            return View(products);

        }
        public ActionResult Gender(string gen)
        {
            IEnumerable<product> products = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var rs = client.GetAsync("home?gen=" + gen);
                rs.Wait();
                var re = rs.Result;
                if (re.IsSuccessStatusCode)
                {
                    var readRe = re.Content.ReadAsAsync<IList<product>>();
                    readRe.Wait();
                    products = readRe.Result;
                }

            }

            return View(products);
        }
        public ActionResult Details(string pid)
        {
            product p = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var rs = client.GetAsync("home?pid=" + pid);
                rs.Wait();
                var re = rs.Result;
                if (re.IsSuccessStatusCode)
                {
                    var readRe = re.Content.ReadAsAsync<product>();
                    readRe.Wait();
                    p = (product)readRe.Result;
                }

            }
            return View(p);
        }
    }
}