using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Views
{
    public class MainView
    {

        public ConsoleKeyInfo MainMenu()
        {
            View mainMenu = new View();

            mainMenu.AddMenuText("");
            mainMenu.AddMenuOption("Add Customer")
            .AddMenuOption("Select Customer")
            .AddMenuText("Press 0 to exit.");

            Console.Write(mainMenu.GetFullMenu());
            ConsoleKeyInfo userOption = Console.ReadKey();
            return userOption;
        }

    }
}
