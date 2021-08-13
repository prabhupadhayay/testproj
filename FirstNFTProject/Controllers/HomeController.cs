using Nethereum.ABI;
using Nethereum.ABI.FunctionEncoding.Attributes;
//using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;



namespace FirstNFTProject.Controllers
{
    public class HomeController : Controller
    {
       
            public async Task<ActionResult> Index()
            {
            return RedirectToAction("Register", "Accounts");

           
            }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}