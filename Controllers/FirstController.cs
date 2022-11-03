using Microsoft.AspNetCore.Mvc;
using App.Services;

namespace App.Controllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;
        private readonly ProductService _productService;

        [ActivatorUtilitiesConstructor]
        public FirstController(
            ILogger<FirstController> logger
            , ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        public string Index()
        {
            _logger.LogInformation("Index Action");
            return "I'm First's Index";
        }

        public void Nothing()
        {
            _logger.LogInformation("Nothing Action");
            Response.Headers.Add("hi", "Welcome");
        }

        // ViewResult   |   View()
        public IActionResult HelloView(string username)
        {
            if (string.IsNullOrEmpty(username)) {
                username = "Guest";
            }

            // Default
            // /View/<ControllerName>/<ActionName>.cshtml
            return View("MyViews/hello1.cshtml", username);
        }

        public IActionResult ViewProduct(int? id)
        {
            var product = _productService.Where(p => p.Id == id).FirstOrDefault();
            if (product == null)
            {
                TempData["statusMessage"] = "ProductId Not Found!";
                return Redirect(Url.Action("Index", "Home"));
            }
            // return Content($"Id Product = {id}");

            // Model
            // return View(product);

            // ViewData
            // this.ViewData["product"] = product;
            // this.ViewData["title"] = product.Name;
            // return View("ViewProduct2");

            // ViewBag
            ViewBag.product = product;
            return View("ViewProduct3");

            // TempData
        }
    }
}