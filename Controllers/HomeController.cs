using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace MvcApiCall.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allArticles = Article.GetArticles("[QJmUAg80RmZlE8EF0Nbhq5smFHmX0zqA]");
            return View(allArticles);
        }
    }
}