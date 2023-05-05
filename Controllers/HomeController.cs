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

			Invoice invoice1 = new Invoice();
			invoice1.InvoiceRows.Add(new InvoiceRow { Item = "Item 1", Price = 10.00 });
			invoice1.InvoiceRows.Add(new InvoiceRow { Item = "Item 2", Price = 20.10 });
			invoice1.InvoiceRows.Add(new InvoiceRow { Item = "Item 3", Price = 5.50 });

			Invoice invoice2 = new Invoice();
			invoice2.InvoiceRows.Add(new InvoiceRow { Item = "Item 4", Price = 15.00 });
			invoice2.InvoiceRows.Add(new InvoiceRow { Item = "Item 5", Price = 8.20 });

			List<Invoice> invoices = new List<Invoice>();
			invoices.Add(invoice1);
			invoices.Add(invoice2);

			//Invoice objInvoice = new Invoice();
			//objInvoice.InvoiceRows.Add(new InvoiceRow { Item = "item1", Price = 10.20 });
			//objInvoice.InvoiceRows.Add(new InvoiceRow { Item = "item2", Price = 20.10 });

			//List<Invoice> invoices = new List<Invoice>();
			//invoices.Add(objInvoice);

			//objInvoice.Items = new string[] { "item1", "item2" };

			//objInvoice.Prices = new double[] {10.00, 20.10};


			//Invoice[] invoices = new Invoice[]{objInvoice};


			return View(invoices);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}