using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// getting the Product Model Class
using PracticeMvc.Models;

namespace PracticeMvc.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;


        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        // setup model instance her
        public IActionResult Index()
        {
            // creating instance of ProductModel
            var productObj = new ProductModel(){Id = 112, ProductName = "Something Bla Bla"};
            return View(productObj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}