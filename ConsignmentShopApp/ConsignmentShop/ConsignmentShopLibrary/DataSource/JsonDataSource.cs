using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary.DataSource
{
	public class JsonDataSource : IDataSource
	{
		public void LoadData()
		{
			
		}

		public void SaveData(object data)
		{
			
		}

		public List<Item> GetItemsNotSoldYet()
		{
			return new List<Item>();
		}

		public List<Vendor> GetVendors()
		{
			return new List<Vendor>();
		}
	}
}
