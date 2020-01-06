using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
	public partial class ConsignmentShop : Form
	{
		readonly IDataSource dataSource;
		readonly Profits profit;
		readonly NewStoreItems newItems;

		List<Vendor> vendors = new List<Vendor>();

		BindingSource itemsBinding = new BindingSource();
		BindingSource cartBinding = new BindingSource();
		BindingSource vendorsBinding = new BindingSource();

		public ConsignmentShop(IDataSource pDataSource, Profits pProfit, NewStoreItems pNewItems)
		{
			InitializeComponent();

			dataSource = pDataSource;
			profit = pProfit;
			newItems = pNewItems;
		}


		private void loadData_Click(object sender, EventArgs e)
		{
			dataSource.LoadData();

			itemsBinding.DataSource = dataSource.GetItemsNotSoldYet();
			itemsListbox.DataSource = itemsBinding;

			itemsListbox.DisplayMember = "Display";
			itemsListbox.ValueMember = "Display";

			vendors = dataSource.GetVendors();

			vendorsBinding.DataSource = vendors;
			vendorListbox.DataSource = vendorsBinding;

			vendorListbox.DisplayMember = "Display";
			vendorListbox.ValueMember = "Display";

			itemsBinding.ResetBindings(false);
			vendorsBinding.ResetBindings(false);
		}

		private void addToCart_Click(object sender, EventArgs e)
		{
			Item selectedItem = (Item)itemsListbox.SelectedItem;

			cartBinding.DataSource = profit.shoppingCartData;
			shoppingCartListbox.DataSource = cartBinding;

			shoppingCartListbox.DisplayMember = "Display";
			shoppingCartListbox.ValueMember = "Display";

			profit.shoppingCartData.Add(selectedItem);

			cartBinding.ResetBindings(false);
		}

		private void makePurchase_Click(object sender, EventArgs e)
		{
			profit.CalculateShareOfVendorStore();

			storeProfitValue.Text = string.Format("${0}", profit.storeProfit);

			profit.shoppingCartData.Clear();

			if (newItems.NewItemWasAdded == true)
			{
				itemsBinding.DataSource = newItems.GetItemsNotSoldYet();
			}
			else 
			{
				itemsBinding.DataSource = dataSource.GetItemsNotSoldYet();
			}

			cartBinding.ResetBindings(false);
			itemsBinding.ResetBindings(false);
			vendorsBinding.ResetBindings(false);
		}

		private void addNewStoreItem_Click(object sender, EventArgs e)
		{
			var newvdr = newItems.LoadNewVendors(vendorFirstNameTextBox.Text, vendorLastNameTextBox.Text);
			vendors.Add(newvdr);

			newItems.LoadNewItems(
				 titleTextBox.Text,
				 Convert.ToDecimal(priceTextBox.Text),
				 newvdr);

			itemsBinding.DataSource = newItems.GetItemsNotSoldYet();
			itemsListbox.DataSource = itemsBinding;

			vendorsBinding.DataSource = vendors;
			vendorListbox.DataSource = vendorsBinding;

			vendorListbox.DisplayMember = "Display";
			vendorListbox.ValueMember = "Display";

			itemsListbox.DisplayMember = "Display";
			itemsListbox.ValueMember = "Display";

			itemsBinding.ResetBindings(false);
			vendorsBinding.ResetBindings(false);
		}
	}
}
