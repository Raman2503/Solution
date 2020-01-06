using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsignmentShopLibrary
{

	/// <summary>
	/// Load Data using Dummy Data.
	/// </summary>
	public class DummyData : IDataSource
	{
		Store store = new Store();
		NewStoreItems newStoreItems = new NewStoreItems();

		void IDataSource.LoadData()
		{
			store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
			store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

			store.Items.Add(new Item { Title = "Moby Dick", Description = "A book about a whale", Price = 4.50M, Owner = store.Vendors[0] });
			store.Items.Add(new Item { Title = "A Tale of Two Cities", Description = "A book about revolution", Price = 3.80M, Owner = store.Vendors[1] });
			store.Items.Add(new Item { Title = "Harry Potter Book 1", Description = "A book about a boy", Price = 5.20M, Owner = store.Vendors[1] });
			store.Items.Add(new Item { Title = "Jane Eyre", Description = "A book about a girl", Price = 1.50M, Owner = store.Vendors[0] });

			store.Name = "Seconds are Better";
		}

		public void SaveData(object data)
		{
			throw new NotImplementedException();
		}

		List<Item> IDataSource.GetItemsNotSoldYet()
		{
			newStoreItems.NewItemWasAdded = false;
			return store.Items.Where(x => x.Sold == false).ToList();
		}

		List<Vendor> IDataSource.GetVendors()
		{
			return store.Vendors;
		}
	}
}
