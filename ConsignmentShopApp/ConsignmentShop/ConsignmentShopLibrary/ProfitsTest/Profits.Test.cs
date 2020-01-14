using System;
using NUnit.Framework;
using ConsignmentShopLibrary;

namespace ProfitsTest
{
    [TestFixture]
    public class ProfitsTest
    {
        [Test]
        public void ClearedShoppingCartTest()
        {
            // Arrange 
            Profits profits = new Profits();
            Store store = new Store();

            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Items.Add(new Item { Title = "Moby Dick", Description = "A book about a whale", Price = 4.50M, Owner = store.Vendors[0] });

            profits.shoppingCartData.Add(new Item { Title = "Moby Dick", Description = "A book about a whale", Price = 4.50M, Owner = store.Vendors[0] });

            //Act
            var cartItems = profits.CalculateShareOfVendorStore();

			// Assert
			Assert.IsEmpty(cartItems);
        }
    }
}
