using System.Diagnostics;
using InvoicePrinter.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoicePrinter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Invoices()
        {

            Invoice objInvoice = new Invoice();
            objInvoice.Items = new string[] { "item1", "item2" };

            objInvoice.Prices = new double[] {10.00, 20.10};
            

            Invoice[] invoices = new Invoice[]{objInvoice};
            

            return View(invoices);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}