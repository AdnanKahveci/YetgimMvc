using Microsoft.AspNetCore.Mvc;
using YetGimMvc.Models;
namespace YetGimMvc.Controllers;

public class CarsController : Controller
{
    // GET
    List<Car> cars = new List<Car>()
    {
        new Car { Name = "Toyota", Model = "Corolla", Price = 18000, FuelType = "Petrol" },
        new Car { Name = "Tesla", Model = "Model 3", Price = 35000, FuelType = "Electric" },
        new Car { Name = "Ford", Model = "Focus", Price = 18000, FuelType = "Diesel" },
        new Car { Name = "Honda", Model = "Civic", Price = 22000, FuelType = "Petrol" },
        new Car { Name = "BMW", Model = "i3", Price = 45000, FuelType = "Electric" },
        new Car { Name = "Volkswagen", Model = "Passat", Price = 25000, FuelType = "Diesel" },

    };
    public IActionResult Index()
    {
        return View(cars);
    }
    public IActionResult Filter()
    {
        List<Car> filteredCars = cars.Where(x => x.Price < 20000 && x.FuelType == "Petrol").ToList();     
        return View(filteredCars);
    }
}