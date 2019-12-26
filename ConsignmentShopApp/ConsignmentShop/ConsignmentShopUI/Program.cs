using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // composition root
			//IDataSource dataSource = new DummyData();
			IDataSource dataSource = new XmlData();
			Profits profit = new Profits();
			NewStoreItems newItems = new NewStoreItems();

			var form = new ConsignmentShop(dataSource,profit,newItems);

            // run your logic
			Application.Run(form);
        }
    }
}
