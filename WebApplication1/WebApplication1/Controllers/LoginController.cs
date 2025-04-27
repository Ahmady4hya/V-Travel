using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private TourContext Context { get; set; }

        public LoginController(TourContext ctx) => Context = ctx;
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            UserLogin Test = Context.UserLogin.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (Test == null)
            {
                return View();
            }
            return RedirectToAction("Index","Home");
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserLogin su)
        {
            if(ModelState.IsValid)
            {
                Context.UserLogin.Add(su);
                Context.SaveChanges();
                return View("Login");
            }
            return View();
        }
    }
}
