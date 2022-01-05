using CardDeckAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CardDeckAPI.Controllers
{
    public class HomeController : Controller
    {
        CardsDAL cd = new CardsDAL();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetNewDeck(string id)
        {
            NewDeck nd = new NewDeck();
            nd = cd.GetNewDeck(id);
            return View(nd);
        }
        public IActionResult DrawCards(string id)
        {
            DrawCards dc = new DrawCards();
            dc = cd.GetCards(id);
            return View(dc);
        }
     

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
