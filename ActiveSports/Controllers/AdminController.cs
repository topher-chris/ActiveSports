using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActiveSports.Models;
using System.Linq;

namespace ActiveSports.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Products);
        public ViewResult Edit(int productId) =>
            View(repository.Products
                .FirstOrDefault(p => p.ProductID == productId));

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(product);
            }
        }
        public ViewResult Create() => View("Edit", new Product());
    }
}