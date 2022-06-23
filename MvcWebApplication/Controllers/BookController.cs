using Microsoft.AspNetCore.Mvc;

namespace MvcWebApplication.Controllers
{
    public class BookController : Controller
    {
        public IActionResult AddNew()
        {
            return View();
        }
    }
}
