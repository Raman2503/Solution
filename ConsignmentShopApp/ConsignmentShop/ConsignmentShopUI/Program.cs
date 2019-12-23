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


            var form = new ConsignmentShop(dataSource);

            // run your logic
			Application.Run(form);
        }
    }
}
