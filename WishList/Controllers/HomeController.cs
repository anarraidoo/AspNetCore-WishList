using System;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
