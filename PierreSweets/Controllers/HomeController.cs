using Microsoft.AspNetCore.Mvc;

namespace PierreSweets.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("Treats")]
      public ActionResult Index()
      {
        return View();
      }

    }
}