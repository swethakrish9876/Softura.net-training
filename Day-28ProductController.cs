using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using task_product.Models;

namespace task_product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                ProductDBContext dBContext = new ProductDBContext();
                dBContext.Add(p);
                dBContext.SaveChanges();
                return Content("Saved");
            }
            return View("Index");
        }
    }
}

