using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index2()
        {
           return View();
        }
        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }
    }
}
