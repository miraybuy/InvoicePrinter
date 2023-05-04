using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace InvoicePrinter.Models
{
	public class Invoice //without array but with collection 
		//invoice row with item and price 
		//n numeri di fatture collection
	{
		private string[] m_items;
		private double[] m_prices;

		public Invoice()
		{//dentro costruttore allochiamo i variabili 

			m_items = new string[0];
			m_prices = new double[0];
		}

		public string[] Items
		{
			get
			{
				return m_items;
			}
			set
			{
				
					//log ci sono 27 elementi per esempio 
				
				m_items = value;
			}
		}

		public double[] Prices
		{
			get
			{
				return m_prices;
			}
			set
			{
			
				m_prices = value;
			}
		}
		//	public string[] GetItems()
		//	{
		//		return m_items;
		//	}

		//	public void SetItems(string[] items)
		//	{

		//		m_items = items;
		//	}
	}

	//  public class Invoice
	//  {
	//      public string? Item { get; set; }
	//      public double? Price { get; set; }

	//      public Invoice(string? item, double price)
	//      {
	//          Item = item;
	//          Price = price;
	//      }

	//      public static Invoice[] invoices =
	//      {
	//          new Invoice("IPhone11", 900.70),
	//          new Invoice ("Tv", 2000.50),
	//          new Invoice ("Ipad", 840.35),
	//	new Invoice ("Printer", 840.35),
	//	new Invoice ("Vacuum Cleaner", 75.34),
	//	new Invoice ("Smart Watch", 840.35),
	//	new Invoice ("Headphones", 112.00),
	//	new Invoice ("Mouse", 52.30),
	//	new Invoice ("Keyboard", 182.00),
	//	new Invoice ("Coffee Machine", 225.35),


	//};
	//  }
}
