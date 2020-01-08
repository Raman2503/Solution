namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.headerText = new System.Windows.Forms.Label();
			this.addToCart = new System.Windows.Forms.Button();
			this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
			this.shoppingCartListbox = new System.Windows.Forms.ListBox();
			this.makePurchase = new System.Windows.Forms.Button();
			this.itemsListbox = new System.Windows.Forms.ListBox();
			this.itemsListboxLabel = new System.Windows.Forms.Label();
			this.vendorListboxLabel = new System.Windows.Forms.Label();
			this.vendorListbox = new System.Windows.Forms.ListBox();
			this.StorePayoutLable = new System.Windows.Forms.Label();
			this.storeProfitValue = new System.Windows.Forms.Label();
			this.loadData = new System.Windows.Forms.Button();
			this.addNewStoreItem = new System.Windows.Forms.Button();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.titleTextBoxLabel = new System.Windows.Forms.Label();
			this.priceTextBoxLabel = new System.Windows.Forms.Label();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.vendorTextBoxLabel = new System.Windows.Forms.Label();
			this.vendorFirstNameTextBox = new System.Windows.Forms.TextBox();
			this.vendorLastNameTextBox = new System.Windows.Forms.TextBox();
			this.clearData = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerText
			// 
			this.headerText.AutoSize = true;
			this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerText.Location = new System.Drawing.Point(25, 54);
			this.headerText.Name = "headerText";
			this.headerText.Size = new System.Drawing.Size(405, 37);
			this.headerText.TabIndex = 0;
			this.headerText.Text = "Consignment Shop Demo";
			// 
			// addToCart
			// 
			this.addToCart.Location = new System.Drawing.Point(416, 181);
			this.addToCart.Name = "addToCart";
			this.addToCart.Size = new System.Drawing.Size(127, 49);
			this.addToCart.TabIndex = 3;
			this.addToCart.Text = "Add To Cart ->";
			this.addToCart.UseVisualStyleBackColor = true;
			this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
			// 
			// shoppingCartListboxLabel
			// 
			this.shoppingCartListboxLabel.AutoSize = true;
			this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shoppingCartListboxLabel.Location = new System.Drawing.Point(603, 101);
			this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
			this.shoppingCartListboxLabel.Size = new System.Drawing.Size(129, 20);
			this.shoppingCartListboxLabel.TabIndex = 5;
			this.shoppingCartListboxLabel.Text = "Shopping Cart ";
			// 
			// shoppingCartListbox
			// 
			this.shoppingCartListbox.FormattingEnabled = true;
			this.shoppingCartListbox.ItemHeight = 20;
			this.shoppingCartListbox.Location = new System.Drawing.Point(607, 124);
			this.shoppingCartListbox.Name = "shoppingCartListbox";
			this.shoppingCartListbox.Size = new System.Drawing.Size(317, 164);
			this.shoppingCartListbox.TabIndex = 4;
			// 
			// makePurchase
			// 
			this.makePurchase.Location = new System.Drawing.Point(797, 312);
			this.makePurchase.Name = "makePurchase";
			this.makePurchase.Size = new System.Drawing.Size(127, 49);
			this.makePurchase.TabIndex = 6;
			this.makePurchase.Text = "Purchase";
			this.makePurchase.UseVisualStyleBackColor = true;
			this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
			// 
			// itemsListbox
			// 
			this.itemsListbox.FormattingEnabled = true;
			this.itemsListbox.ItemHeight = 20;
			this.itemsListbox.Location = new System.Drawing.Point(32, 124);
			this.itemsListbox.Name = "itemsListbox";
			this.itemsListbox.Size = new System.Drawing.Size(317, 164);
			this.itemsListbox.TabIndex = 1;
			// 
			// itemsListboxLabel
			// 
			this.itemsListboxLabel.AutoSize = true;
			this.itemsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.itemsListboxLabel.Location = new System.Drawing.Point(28, 101);
			this.itemsListboxLabel.Name = "itemsListboxLabel";
			this.itemsListboxLabel.Size = new System.Drawing.Size(103, 20);
			this.itemsListboxLabel.TabIndex = 2;
			this.itemsListboxLabel.Text = "Store Items";
			// 
			// vendorListboxLabel
			// 
			this.vendorListboxLabel.AutoSize = true;
			this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vendorListboxLabel.Location = new System.Drawing.Point(28, 385);
			this.vendorListboxLabel.Name = "vendorListboxLabel";
			this.vendorListboxLabel.Size = new System.Drawing.Size(76, 20);
			this.vendorListboxLabel.TabIndex = 8;
			this.vendorListboxLabel.Text = "Vendors";
			// 
			// vendorListbox
			// 
			this.vendorListbox.FormattingEnabled = true;
			this.vendorListbox.ItemHeight = 20;
			this.vendorListbox.Location = new System.Drawing.Point(32, 408);
			this.vendorListbox.Name = "vendorListbox";
			this.vendorListbox.Size = new System.Drawing.Size(317, 164);
			this.vendorListbox.TabIndex = 7;
			// 
			// StorePayoutLable
			// 
			this.StorePayoutLable.AutoSize = true;
			this.StorePayoutLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StorePayoutLable.Location = new System.Drawing.Point(603, 385);
			this.StorePayoutLable.Name = "StorePayoutLable";
			this.StorePayoutLable.Size = new System.Drawing.Size(106, 20);
			this.StorePayoutLable.TabIndex = 9;
			this.StorePayoutLable.Text = "Store Profit:";
			// 
			// storeProfitValue
			// 
			this.storeProfitValue.AutoSize = true;
			this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.storeProfitValue.Location = new System.Drawing.Point(709, 385);
			this.storeProfitValue.Name = "storeProfitValue";
			this.storeProfitValue.Size = new System.Drawing.Size(54, 20);
			this.storeProfitValue.TabIndex = 10;
			this.storeProfitValue.Text = "$0.00";
			// 
			// loadData
			// 
			this.loadData.Location = new System.Drawing.Point(32, 12);
			this.loadData.Name = "loadData";
			this.loadData.Size = new System.Drawing.Size(117, 31);
			this.loadData.TabIndex = 11;
			this.loadData.Text = "Load Data";
			this.loadData.UseVisualStyleBackColor = true;
			this.loadData.Click += new System.EventHandler(this.loadData_Click);
			// 
			// addNewStoreItem
			// 
			this.addNewStoreItem.Location = new System.Drawing.Point(581, 503);
			this.addNewStoreItem.Name = "addNewStoreItem";
			this.addNewStoreItem.Size = new System.Drawing.Size(113, 48);
			this.addNewStoreItem.TabIndex = 13;
			this.addNewStoreItem.Text = "Add new Store Item";
			this.addNewStoreItem.UseVisualStyleBackColor = true;
			this.addNewStoreItem.Click += new System.EventHandler(this.addNewStoreItem_Click);
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new System.Drawing.Point(581, 557);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(151, 26);
			this.titleTextBox.TabIndex = 14;
			// 
			// titleTextBoxLabel
			// 
			this.titleTextBoxLabel.AutoSize = true;
			this.titleTextBoxLabel.Location = new System.Drawing.Point(537, 560);
			this.titleTextBoxLabel.Name = "titleTextBoxLabel";
			this.titleTextBoxLabel.Size = new System.Drawing.Size(38, 20);
			this.titleTextBoxLabel.TabIndex = 15;
			this.titleTextBoxLabel.Text = "Title";
			// 
			// priceTextBoxLabel
			// 
			this.priceTextBoxLabel.AutoSize = true;
			this.priceTextBoxLabel.Location = new System.Drawing.Point(531, 592);
			this.priceTextBoxLabel.Name = "priceTextBoxLabel";
			this.priceTextBoxLabel.Size = new System.Drawing.Size(44, 20);
			this.priceTextBoxLabel.TabIndex = 17;
			this.priceTextBoxLabel.Text = "Price";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(581, 589);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(151, 26);
			this.priceTextBox.TabIndex = 16;
			// 
			// vendorTextBoxLabel
			// 
			this.vendorTextBoxLabel.AutoSize = true;
			this.vendorTextBoxLabel.Location = new System.Drawing.Point(735, 560);
			this.vendorTextBoxLabel.Name = "vendorTextBoxLabel";
			this.vendorTextBoxLabel.Size = new System.Drawing.Size(61, 20);
			this.vendorTextBoxLabel.TabIndex = 19;
			this.vendorTextBoxLabel.Text = "Vendor";
			// 
			// vendorFirstNameTextBox
			// 
			this.vendorFirstNameTextBox.Location = new System.Drawing.Point(797, 557);
			this.vendorFirstNameTextBox.Name = "vendorFirstNameTextBox";
			this.vendorFirstNameTextBox.Size = new System.Drawing.Size(87, 26);
			this.vendorFirstNameTextBox.TabIndex = 18;
			// 
			// vendorLastNameTextBox
			// 
			this.vendorLastNameTextBox.Location = new System.Drawing.Point(890, 557);
			this.vendorLastNameTextBox.Name = "vendorLastNameTextBox";
			this.vendorLastNameTextBox.Size = new System.Drawing.Size(87, 26);
			this.vendorLastNameTextBox.TabIndex = 20;
			// 
			// clearData
			// 
			this.clearData.Location = new System.Drawing.Point(169, 12);
			this.clearData.Name = "clearData";
			this.clearData.Size = new System.Drawing.Size(117, 31);
			this.clearData.TabIndex = 21;
			this.clearData.Text = "Clear Data";
			this.clearData.UseVisualStyleBackColor = true;
			this.clearData.Click += new System.EventHandler(this.clearData_Click);
			// 
			// ConsignmentShop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 635);
			this.Controls.Add(this.clearData);
			this.Controls.Add(this.vendorLastNameTextBox);
			this.Controls.Add(this.vendorTextBoxLabel);
			this.Controls.Add(this.vendorFirstNameTextBox);
			this.Controls.Add(this.priceTextBoxLabel);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.titleTextBoxLabel);
			this.Controls.Add(this.titleTextBox);
			this.Controls.Add(this.addNewStoreItem);
			this.Controls.Add(this.loadData);
			this.Controls.Add(this.storeProfitValue);
			this.Controls.Add(this.StorePayoutLable);
			this.Controls.Add(this.vendorListboxLabel);
			this.Controls.Add(this.vendorListbox);
			this.Controls.Add(this.makePurchase);
			this.Controls.Add(this.shoppingCartListboxLabel);
			this.Controls.Add(this.shoppingCartListbox);
			this.Controls.Add(this.addToCart);
			this.Controls.Add(this.itemsListboxLabel);
			this.Controls.Add(this.itemsListbox);
			this.Controls.Add(this.headerText);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ConsignmentShop";
			this.Text = "Consignment Shop Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label StorePayoutLable;
        private System.Windows.Forms.Label storeProfitValue;
		private System.Windows.Forms.Button loadData;
		private System.Windows.Forms.Button addNewStoreItem;
		private System.Windows.Forms.Label titleTextBoxLabel;
		private System.Windows.Forms.Label priceTextBoxLabel;
		private System.Windows.Forms.Label vendorTextBoxLabel;
		public System.Windows.Forms.TextBox titleTextBox;
		public System.Windows.Forms.TextBox priceTextBox;
		public System.Windows.Forms.TextBox vendorFirstNameTextBox;
		public System.Windows.Forms.TextBox vendorLastNameTextBox;
		private System.Windows.Forms.Button clearData;
	}
}

