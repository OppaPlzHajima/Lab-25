using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HackBuster.Models;

namespace HackBuster.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Result(User user)
        {
            ViewBag.Name = user.FirstName;
            ViewBag.FirstName = user.FirstName;
            return View();
        }


        public IActionResult RegisterItem()
        {
            return View();
        }
        public IActionResult ItemResultView()
        {
            return View();
        }
        //[HttpPost]
        ////public IActionResult ItemResultView(UserItem userItem)
        ////{
        ////    if (ModelState.IsValid)
        ////    {

        ////        //ViewBag.Name = userItem.Name;
        ////        //ViewBag.Price = userItem.Price;
        ////        //ViewBag.Description = userItem.Description;
        ////        //ViewBag.Quantity = userItem.Quantity;
        ////        return View(userItem);

        ////    }
        ////    else
        ////    {
        ////        return View(userItem);

        ////    }



    
    }
}
