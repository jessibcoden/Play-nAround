using Draft.DataAccess;
using Draft.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Views
{
    class AllCustomersView
    {

        public Customer SelectActiveCustomer()
        {
            var allCustomers = new List<Customer>();
            var customerQuery = new CustomerQuery();
            var customers = customerQuery.GetAllCustomers();

            var viewAllCustomers = new View();
            viewAllCustomers.AddMenuText("");
            viewAllCustomers.AddMenuText("Select Customer:");

            foreach (var customer in customers)
            {
                allCustomers.Add(customer);
                viewAllCustomers.AddMenuOption($"{customer.FirstName} {customer.LastName}");
            }

            viewAllCustomers.AddMenuText("Press 0 to go BACK.");

            Console.Write(viewAllCustomers.GetFullMenu());

            int customerSelected = int.Parse(Console.ReadKey().KeyChar.ToString());
            var selectedCustomer = allCustomers[customerSelected - 1];

            return allCustomers.First<Customer>(x => x == selectedCustomer);

        }
    }
}
