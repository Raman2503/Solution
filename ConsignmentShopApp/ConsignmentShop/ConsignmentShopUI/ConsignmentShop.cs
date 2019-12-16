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
		readonly SetupData setupData;

		//private SetupData setupdata = new SetupData();
        Profits profit = new Profits();

        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        

        public ConsignmentShop(SetupData pSetupData)
        {
			this.setupData = pSetupData;

			InitializeComponent();
            setupData.GenerateData ();


            itemsBinding.DataSource = setupData.GetItemsNotSoldYet();
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = profit.shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = setupData.GetVendors();
            vendorListbox.DataSource = vendorsBinding;

            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListbox.SelectedItem;

            profit.shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);

        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            var items = profit.CalculateShareOfVendorStore();

            // ui code
            itemsBinding.DataSource = setupData.GetItemsNotSoldYet();

            storeProfitValue.Text = string.Format("${0}", profit.storeProfit);

            profit.shoppingCartData.Clear();

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
