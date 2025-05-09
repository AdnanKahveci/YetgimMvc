using ECommerce.DataAccess.Contexts;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers;

public class ProductController : Controller
{
    BaseDbContext context = new BaseDbContext();
    // GET
    public IActionResult Index()
    {
        List<Product> products = context.Products.ToList();
        return View(products);
    }
}