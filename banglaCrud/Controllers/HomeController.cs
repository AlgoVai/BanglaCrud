using banglaCrud.Data;
using banglaCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace banglaCrud.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
     





        [HttpPost]
        public IActionResult postHouse(House house)
        {
            var data = new House
            {
                HouseName = house.HouseName,
                price = house.price,
                sqFeet = house.sqFeet
            };
            _context.Add(data);
            _context.SaveChanges();
            return RedirectToAction("getHouseList","House");
        }

        




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
