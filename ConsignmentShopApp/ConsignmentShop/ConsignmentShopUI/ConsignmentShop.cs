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
		List<Item> items = new List<Item>();

		BindingSource itemsBinding = new BindingSource();
		BindingSource cartBinding = new BindingSource();
		BindingSource vendorsBinding = new BindingSource();

		BindingSource itemsBinding1 = new BindingSource();
		BindingSource itemsBinding2 = new BindingSource();



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

			items = dataSource.GetItemsNotSoldYet();

			itemsBinding.DataSource = items;
			itemsListbox.DataSource = itemsBinding;

			itemsListbox.DisplayMember = "Display";
			itemsListbox.ValueMember = "Display";

			vendors = dataSource.GetVendors();

			vendorsBinding.DataSource = dataSource.GetVendors();
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

			itemsBinding.DataSource = newItems.GetItemsNotSoldYet();
			itemsBinding.DataSource = dataSource.GetItemsNotSoldYet();

			cartBinding.ResetBindings(false);
			itemsBinding.ResetBindings(false);
			vendorsBinding.ResetBindings(false);
		}

		private void addNewStoreItem_Click(object sender, EventArgs e)
		{
			var newvdr = newItems.LoadNewVendors(vendorFirstNameTextBox.Text, vendorLastNameTextBox.Text);
			vendors.Add(newvdr);

			var newitm = newItems.LoadNewItems(
				 titleTextBox.Text,
				 Convert.ToDecimal(priceTextBox.Text),
				 newvdr);
			items.Add(newitm);

			itemsBinding.DataSource = items;
			itemsListbox.DataSource = itemsBinding;

			vendorsBinding.DataSource = vendors;
			vendorListbox.DataSource = vendorsBinding;

			vendorListbox.DisplayMember = "Display";
			vendorListbox.ValueMember = "Display";

			itemsListbox.DisplayMember = "Display";
			itemsListbox.ValueMember = "Display";

			itemsBinding.ResetBindings(false);
			vendorsBinding.ResetBindings(false);

			titleTextBox.Clear();
			priceTextBox.Clear();
			vendorFirstNameTextBox.Clear();
			vendorLastNameTextBox.Clear();
		}

		private void clearData_Click(object sender, EventArgs e)
		{
			vendorsBinding.Clear();
			itemsBinding.Clear();

			itemsBinding.ResetBindings(false);
			vendorsBinding.ResetBindings(false);
		}
	}
}
