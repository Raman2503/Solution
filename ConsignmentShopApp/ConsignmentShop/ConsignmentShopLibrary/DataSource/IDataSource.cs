using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
	public interface IDataSource
	{
		void LoadData();

		void SaveData(object data);
		
		List<Item> GetItemsNotSoldYet();

		List<Vendor> GetVendors();
	}

}
