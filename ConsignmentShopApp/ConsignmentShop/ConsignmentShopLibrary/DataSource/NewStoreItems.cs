using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopLibrary 
{
	public class NewStoreItems		 
	{
		Store store = new Store();
		Item item = new Item();
		public List<Vendor> vendor = new List<Vendor>();


		public TextBox titleTextbox;
		public TextBox priceTextbox;
		public TextBox vendorFirstNameTextbox;
		public TextBox vendorLastNameTextbox;

		public void LoadNewVendors()
		{
			store.Vendors.Add(new Vendor { FirstName = vendorFirstNameTextbox.Text, LastName = vendorLastNameTextbox.Text });
		}
		
		public void LoadNewItems()
		{
			store.Items.Add(new Item { Title = titleTextbox.Text, Price = Convert.ToDecimal(priceTextbox.Text), Owner = store.Vendors.Last()});
		}

		public List<Item> GetItemsNotSoldYet()
		{
			return store.Items.Where(x => x.Sold == false).ToList();
		}

		public List<Vendor> GetVendors()
		{
			return store.Vendors;
		}
	}
}
