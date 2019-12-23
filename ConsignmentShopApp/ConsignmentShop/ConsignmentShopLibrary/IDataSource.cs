using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsignmentShopLibrary
{
	public interface IDataSource
	{
		void LoadData();
		
		List<Item> GetItemsNotSoldYet();

		List<Vendor> GetVendors();
	}


	// Load Data using Dummy Data.
	public class DummyData : IDataSource
	{
		Store store = new Store();

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

		List<Item> IDataSource.GetItemsNotSoldYet()
		{
			return store.Items.Where(x => x.Sold == false).ToList();
		}

		List<Vendor> IDataSource.GetVendors()
		{
			return store.Vendors;
		}
	}


	// Load Data using XML Data.
	public class XmlData : IDataSource
	{
		Store store = new Store();
		Item Item = new Item();

		void IDataSource.LoadData()
		{

			XmlDocument docItems = new XmlDocument();
			XmlDocument docVendors = new XmlDocument();

			docVendors.Load("Vendors.xml");

			foreach (XmlNode node in docVendors.DocumentElement)
			{
				store.Vendors.Add(new Vendor { FirstName = node.Attributes["FirstName"]?.InnerText, LastName = node["LastName"]?.InnerText });
			}

			docItems.Load("Items_BillSmith.xml");

			foreach(XmlNode node in docItems.DocumentElement)
			{
				store.Items.Add(new Item { Title = node.Attributes["Title"]?.InnerText, Description = node.Attributes["Description"]?.InnerText, Price = Convert.ToDecimal(node["Price"].InnerText), Owner = store.Vendors[0]});
			}

			docItems.Load("Items_SueJones.xml");

			foreach (XmlNode node in docItems.DocumentElement)
			{
				store.Items.Add(new Item { Title = node.Attributes["Title"]?.InnerText, Description = node.Attributes["Description"]?.InnerText, Price = Convert.ToDecimal(node["Price"].InnerText), Owner = store.Vendors[1] });
			}
		}

		List<Item> IDataSource.GetItemsNotSoldYet()
		{
			return store.Items.Where(x => x.Sold == false).ToList();
		}

		List<Vendor> IDataSource.GetVendors()
		{
			return store.Vendors;
		}

	}
}
