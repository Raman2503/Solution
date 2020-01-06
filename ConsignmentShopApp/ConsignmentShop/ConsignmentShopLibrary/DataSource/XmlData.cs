using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ConsignmentShopLibrary
{
	/// <summary>
	/// Load Data using XML Data.
	/// </summary>
	public class XmlData : IDataSource
	{
		Store store = new Store();
		NewStoreItems newStoreItems = new NewStoreItems();

		public void LoadData()
		{
			XmlDocument docItems = new XmlDocument();
			XmlDocument docVendors = new XmlDocument();

			docVendors.Load("C:\\Users\\Raman Khosravi\\source\\repos\\Raman2503\\Solution\\ConsignmentShopApp\\ConsignmentShop\\ConsignmentShopLibrary\\DataSource\\Vendors.xml");

			foreach (XmlNode node in docVendors.DocumentElement)
			{
				store.Vendors.Add(new Vendor { FirstName = node.Attributes["FirstName"]?.InnerText, LastName = node["LastName"]?.InnerText });
			}

			docItems.Load("C:\\Users\\Raman Khosravi\\source\\repos\\Raman2503\\Solution\\ConsignmentShopApp\\ConsignmentShop\\ConsignmentShopLibrary\\DataSource\\Items_BillSmith.xml");

			foreach(XmlNode node in docItems.DocumentElement)
			{
				store.Items.Add(new Item { Title = node.Attributes["Title"]?.InnerText, Description = node.Attributes["Description"]?.InnerText, Price = Convert.ToDecimal(node["Price"].InnerText), Owner = store.Vendors[0]});
			}

			docItems.Load("C:\\Users\\Raman Khosravi\\source\\repos\\Raman2503\\Solution\\ConsignmentShopApp\\ConsignmentShop\\ConsignmentShopLibrary\\DataSource\\Items_SueJones.xml");

			foreach (XmlNode node in docItems.DocumentElement)
			{
				store.Items.Add(new Item { Title = node.Attributes["Title"]?.InnerText, Description = node.Attributes["Description"]?.InnerText, Price = Convert.ToDecimal(node["Price"].InnerText), Owner = store.Vendors[1] });
			}
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