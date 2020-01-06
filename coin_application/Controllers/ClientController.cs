using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coin_application.Models;

namespace coin_application.Controllers
{
//    [Authorize(Roles = "Admin")]
    [Authorize]
    public class ClientController : Controller
    {
        // GET: Client
        private MyDbContext db = new MyDbContext();

        public ActionResult ByMarket(string id)
        {
            ViewData["market"] = db.Markets.Find(id);
            var list = db.Coins.Where(s => s.MarketId == id).ToList();
            return View("Index2", list);
        }

        public ActionResult Index(string searchString)
        {
            var sc = from s in db.Coins select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                sc = sc.Where(s => s.CoinName.Contains(searchString)
                                   || s.Market.MarketName.Contains(searchString));
            }
            var coins = db.Coins.Include(c => c.Market);
            return View(sc.ToList());
           
        }
      
    }
}