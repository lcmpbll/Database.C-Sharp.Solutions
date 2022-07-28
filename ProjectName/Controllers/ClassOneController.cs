using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class RestaurantController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public RestaurantController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<ClassOne> model = _db.ClassOnes.Include(classOne => classOne.ClassTwo).ToList();
        return View(model);
    }
  }
}