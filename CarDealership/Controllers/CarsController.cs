using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarController : Controllers
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetCars();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel)
    {
      Car myCar = new Car(makeModel);
      return RedirectToAction("Index");
    }
  }
}