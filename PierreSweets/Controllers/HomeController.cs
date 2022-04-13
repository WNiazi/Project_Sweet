using Microsoft.AspNetCore.Mvc;
using PierreSweets.Models;
using System.Linq;

namespace PierreSweets.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    // public ActionResult Index()
    // {
    //   ViewBag.Flavors = _db.Flavors.ToList();
    //   return View(_db.Treats.ToList());
    // }
    }
}