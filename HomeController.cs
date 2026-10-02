using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using _6611_MVCProject.Models;

namespace _6611_MVCProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Books>()
            {
                new Books() { ID = 1, Title = "A Time to Kill", Price = 500, Author = "John Grisham" },
                new Books() { ID = 2, Title = "East of Eden", Price = 700, Author = "John Steinbeck" },
                new Books() { ID = 3, Title = "The House of Mirth", Price = 900, Author = "Edith Wharton" }
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}