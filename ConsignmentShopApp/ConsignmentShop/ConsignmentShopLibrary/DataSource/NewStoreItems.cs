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

		public Vendor LoadNewVendors(string pVendorFirstName, string pVendorLastName)
		{
			return new Vendor { FirstName = pVendorFirstName, LastName = pVendorLastName };
		}

		public Item LoadNewItems(string pTitle, decimal pPrice, Vendor pVendor)
		{
			return new Item { Title = pTitle, Price = pPrice, Owner = pVendor};
		}

		public List<Item> GetItemsNotSoldYet()
		{
			return store.Items.Where(x => x.Sold == false).ToList();
		}
	}
}
