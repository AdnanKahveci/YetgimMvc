using Microsoft.AspNetCore.Mvc;
using YetGimMvc.Models; 
namespace YetGimMvc.Controllers;

public class CustomerController : Controller
{
    // GET
    public IActionResult Index()
    {
        Customer[] customers =
        {
            new Customer { Name = "Ali", Surname = "Kaya", Email = "ali.kaya@example.com" },
            new Customer { Name = "Ayşe", Surname = "Yılmaz", Email = "ayse.yilmaz@example.com" },
            new Customer { Name = "Mehmet", Surname = "Demir", Email = "mehmet.demir@example.com" }
        };

        Employee employee = new Employee
        {
            

        };
        
        return View(customers); 
    }
}