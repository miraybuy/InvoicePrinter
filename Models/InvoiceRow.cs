namespace InvoicePrinter.Models
{
	public class InvoiceRow
	{
		public string? Item { get; set; }
		public double? Price { get; set; }


		public InvoiceRow() 
		{
			Item = new string(" ");
			Price = new double?(0);
		} 
	}
}
