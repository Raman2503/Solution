using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary 
{
	public class NewStoreItems		 
	{
		Store store = new Store();
		Item item = new Item();
		public List<Vendor> vendor = new List<Vendor>();



		public Vendor LoadNewVendors(string pVendorFirstName, string pVendorLastName)
		{
			return new Vendor() { FirstName = pVendorFirstName, LastName = pVendorLastName };
		}
		
		public Item LoadNewItems(string pTitle, decimal pPrice, Vendor pVendor)
		{
			return new Item { Title = pTitle, Price = pPrice, Owner = pVendor};
			
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
