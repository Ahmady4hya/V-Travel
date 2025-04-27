using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private TourContext Context { get; set; }

        public HomeController(TourContext ctx) => Context = ctx;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Book(string id)
        {
            ViewBag.Action = "Add";


            ViewBag.trip = Context.Trip.Find(id);
            
            return View(new Traveler());
        }

        [HttpPost]
        public IActionResult Book(Traveler traveler)
        {
            if (ModelState.IsValid)
            {
                Context.Traveler.Add(traveler);
                Context.SaveChanges();
                return View("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Tours() {
            var trips = Context.Trip.ToList();
            return View(trips);
        }

    }
}