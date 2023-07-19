using Microsoft.AspNetCore.Mvc;

namespace Prashant.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var obj = new { id = 1, name = "Prashant" };
            return View();
            //return "Home_Index Method";
        }
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
