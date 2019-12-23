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
		Item Item = new Item();

		public void LoadData()
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