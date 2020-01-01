using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Profits
    {
        public decimal storeProfit = 0;
        public List<Item> shoppingCartData = new List<Item>();

		public List<Item> CalculateShareOfVendorStore()
        {
            // Calculate share of a vendor and store
            foreach (Item item in shoppingCartData)
            {
				item.Sold = true;
                item.Owner.PaymentDue += (decimal) item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal) item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();
            return shoppingCartData;
        }
    }
}
