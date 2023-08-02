using Microsoft.AspNetCore.Mvc;
using Prashant.BookStore.Models;
using System.Dynamic;
namespace Prashant.BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public required string BookViewData { get; set; }
        public ViewResult Index()
        {
            //var obj = new { id = 1, name = "Prashant" };
            dynamic data = new ExpandoObject();  // annonymius type
            data.Id = 1;
            data.Name = "Prashant";
            ViewBag.Name = "Prashant";
            ViewBag.Data = data;
            //viewData
            ViewData["viewdata"] = new BookModel { Id = 1, Author = "ViewData" };

            // viewdata attribute
            BookViewData = "This is ViewData attribute value";
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
