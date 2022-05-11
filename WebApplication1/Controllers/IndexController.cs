using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.IService;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
            
    public class IndexController : Controller
    {
        Ser ser = new Ser();

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }


        public string Weather(string limit, string offset)
        {
            string js = ser.SaveandPut(limit, offset);

            return js;
        }




    }
}