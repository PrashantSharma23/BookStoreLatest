using Microsoft.AspNetCore.Mvc;

namespace Prashant.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Home_Index Method";
        }
    }
}
