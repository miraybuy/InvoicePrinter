namespace InvoicePrinter.Models
{
    public class Invoice
    {
        public string? Item { get; set; }
        public double? Price { get; set; }

        public Invoice(string? item, double price)
        {
            Item = item;
            Price = price;
        }

        public static Invoice[] invoices =
        {
            new Invoice("IPhone11", 900.70),
            new Invoice ("Tv", 2000.50),
            new Invoice ("Ipad", 840.35),
			new Invoice ("Printer", 840.35),
			new Invoice ("Vacuum Cleaner", 75.34),
			new Invoice ("Smart Watch", 840.35),
			new Invoice ("Headphones", 112.00),
			new Invoice ("Mouse", 52.30),
			new Invoice ("Keyboard", 182.00),
			new Invoice ("Coffee Machine", 225.35),
			

		};
    }
}
