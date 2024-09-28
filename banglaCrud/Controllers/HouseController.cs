using banglaCrud.Data;
using banglaCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace banglaCrud.Controllers
{
    public class HouseController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HouseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]

        public IActionResult getHouseList()
        {
            var data = _context.houses.ToList();
            return View(data);
        }


        [HttpGet]

        public IActionResult editHouse(int id)
        {
            var data = _context.houses.Where(x => x.houseId == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]

        public IActionResult putHouse(House house)
        {
            var data = _context.houses.Where(x=>x.houseId == house.houseId).FirstOrDefault();

            data.houseId = house.houseId;
            data.HouseName = house.HouseName;
            data.price = house.price;
            data.sqFeet = house.sqFeet;

            _context.Update(data);
            _context.SaveChanges();
            return RedirectToAction("getHouseList","House");
        }

        [HttpGet]
        public IActionResult deleteHouse(int id)
        {
            var data = _context.houses.Where(x => x.houseId == id).FirstOrDefault();

            _context.Remove(data);
            _context.SaveChanges();

            return RedirectToAction("getHouseList", "House");
        }


    }
}
