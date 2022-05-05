using Microsoft.AspNetCore.Mvc;
using Shoppin.Client.Data;
using Shoppin.Client.Models;
using System.Diagnostics;

namespace Shoppin.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// cambios
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(ProductContext.Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}