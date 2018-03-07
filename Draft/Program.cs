using Draft.DataAccess;
using Draft.DataAccess.Models;
using Draft.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    class Program
    {
        static Customer _selectedCustomer;

        static void Main(string[] args)
        {

            var mainMenu = new MainView();
            var customerViewType = new CustomerSubMenuView();

                var run = true;
                while (run)
                {
                    ConsoleKeyInfo userInput = mainMenu.MainMenu();

                    switch (userInput.KeyChar)
                    {
                        case '0':
                            run = false;
                            break;

                        case '1': //Add Customer
                        

                            break;

                        case '2': // Select Customer

                        var viewAllCustomers = new AllCustomersView();
                        _selectedCustomer = viewAllCustomers.SelectActiveCustomer();

                        var customerSubMenu = new CustomerSubMenuView();
                        ConsoleKeyInfo userOption = customerSubMenu.CustomerSubMenu();
                        switch (userOption.KeyChar)
                        {
                            case '1': //Buyer Menu
                                break;
                            case '2': //Seller Menu
                                var sellerMenu = new SellerMenuView();
                                ConsoleKeyInfo sellerInput = sellerMenu.SellerMenu();
                                switch (sellerInput.KeyChar)
                                {
                                    case '1'://Add Product
                                        var addProductView = new ProductCreateView();
                                        var customerId = (_selectedCustomer.CustomerId);
                                        var productTitle = addProductView.GetProdcutTitle();
                                        var productPrice = addProductView.GetProdcutPrice();
                                        var productQuantity = addProductView.GetProdcutQuantity();
                                        var addProduct = new ProductCreate();
                                        var newProduct = addProduct.AddNewProduct(customerId, productTitle, productPrice, productQuantity);
                                        break;
                                    case '2': //Delete Product
                                        break;
                                    case '3': //View Revenu Report
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }

                        break;

                        case '3':
                           
                            break;

                        default:
                            break;
                    }
                }
            }

        
    }
}
