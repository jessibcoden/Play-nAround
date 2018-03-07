using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Views
{
    class SellerMenuView
    {

        public ConsoleKeyInfo SellerMenu()
        {
            View sellerMenu = new View();

            sellerMenu.AddMenuText("");
            sellerMenu.AddMenuOption("Add a Product")
            .AddMenuOption("Delete a Product")
            .AddMenuOption("View Revenu Report")
            .AddMenuText("Press 0 to exit.");

            Console.Write(sellerMenu.GetFullMenu());
            ConsoleKeyInfo userOption = Console.ReadKey();
            return userOption;
        }

    }
}
