using Microsoft.AspNetCore.Mvc;
using QLXE.Models;
using System.Diagnostics;

namespace QLXE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
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
        [Route("/post-{slug}-{id:long}.html", Name = "Details")]
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var post = _context.Posts
                .FirstOrDefault(m => (m.PostID == id) && (m.IsActive == true));
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [Route("/car-{slug}-{id:int}.html", Name = "Car")]
        public IActionResult Car(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var car = _context.Cars_Menus
                .Where(m => (m.MenuID == id) && (m.IsActive == true))
                .Take(6).ToList();
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
        [Route("/car-{slug}-{id:int}.html", Name = "CarDetails")]
        public IActionResult CarDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cardetail = _context.Cars
                .FirstOrDefault(m => (m.CarId == id) && (m.IsActive == true));
            if (cardetail == null)
            {
                return NotFound();
            }
            return View(cardetail);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}