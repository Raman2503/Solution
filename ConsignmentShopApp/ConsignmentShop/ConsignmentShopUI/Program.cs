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


			var setupData = new SetupData();
            
			var form = new ConsignmentShop(setupData);

			Application.Run(form);
        }
    }
}
