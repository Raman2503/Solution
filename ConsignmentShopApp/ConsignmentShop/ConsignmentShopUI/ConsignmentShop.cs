using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {

        Profits profit = new Profits();
		IDataSource dummy = new DummyData();
		IDataSource xml = new XmlData();

        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        

        public ConsignmentShop()
        {
			InitializeComponent();
        }
		private void loadData_Click(object sender, EventArgs e)
		{

			xml.LoadData();


			itemsBinding.DataSource = xml.GetItemsNotSoldYet();
			itemsListbox.DataSource = itemsBinding;

			itemsListbox.DisplayMember = "Display";
			itemsListbox.ValueMember = "Display";

			vendorsBinding.DataSource = xml.GetVendors();
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
            var items = profit.CalculateShareOfVendorStore();

            // ui code
            itemsBinding.DataSource = xml.GetItemsNotSoldYet();

            storeProfitValue.Text = string.Format("${0}", profit.storeProfit);

            profit.shoppingCartData.Clear();

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }

	}
}
