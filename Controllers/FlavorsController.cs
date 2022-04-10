using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using PierreSweets.Models;



namespace PierreSweets.Controllers
{
  [Authorize]
  public class FlavorsController : Controller
  {
    private readonly PierreSweetsContext _db;
    private readonly UserManager<ApplicationUser> _userManager; 

    public FlavorsController(UserManager<ApplicationUser> userManager, PierreSweetsContext db)
    {
      _db = db;
      _userManager = userManager;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.OrderBy(aFlavor => aFlavor.FlavorName).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
      return View();
    }
    
    [HttpPost]
     public async Task<ActionResult> Create(Flavor flavor, int TreatId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      flavor.User =currentUser; 
      _db.Flavors.Add(flavor);
      _db.SaveChanges();

      if (TreatId != 0)
      {
        _db.FlavorTreats.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Flavor thisFlavor = _db.Flavors
          .Include(flavor => flavor.FlavorTreatEntities)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }
    public ActionResult Edit(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor flavor, int TreatId)
    {
      if (TreatId !=0)
      {
        _db.FlavorTreats.Add(new FlavorTreat() {TreatId=TreatId, FlavorId=flavor.FlavorId});
      }
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    

    public ActionResult Delete(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      _db.Flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  // [HttpPost]
  //   public ActionResult AddTreat(Flavor flavor, int TreatId)
  //   {
  //     bool isDuplicate = _db.FlavorTreats.Any(join => join.FlavorId == flavor.FlavorId && join.TreatId == TreatId);
  //     if (TreatId != 0 && isDuplicate == false)
  //     {
  //       _db.FlavorTreats.Add(new FlavorTreat() { FlavorId = flavor.FlavorId, TreatId = TreatId });
  //       _db.SaveChanges();
  //     }
  //     return RedirectToAction("Details", new { id = flavor.FlavorId});
  //   }
  
    [HttpPost]
    public ActionResult DeleteTreat(int joinId)
    {
      var joinEntry = _db.FlavorTreats.FirstOrDefault(entry => entry.FlavorTreatId == joinId);
      _db.FlavorTreats.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
} 
