﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hennythingIsPossible
{
    public class HennyApp
    {

        public static void Run()
        {
            Controller obj = new Controller();
            OrderedItems customerOrder = new OrderedItems();
            customerOrder.SalesTaxAmount = 0.06;
            bool userWantsToQuit = false;
         
            HennyArt.DisplayHennyArt();

            do
            {
                switch (Menu.DisplayMainMenu())
                {
                    case MenuEnum.DisplayInventory:
                        var entireMenuList = new MenuView(obj.Menu);
                        entireMenuList.DisplayLiquorMenu();
                        break;
                    case MenuEnum.AddProductToOrder:
                        obj.BuyProduct(obj, customerOrder);
                        customerOrder.CalculateOrderTotal();
                        Console.WriteLine($"\nSubTotal: {customerOrder.SubTotal}");
                        Console.WriteLine($"\nGrandTotal: {customerOrder.GrandTotal}");
                        break;
                    case MenuEnum.LiquorInfoCenter:
                        InfoCenter inf = new InfoCenter("", "");
                        inf.Alcohol();
                        break;
                    case MenuEnum.CashOut:
                        //Display customerOrder
                        ShoppingCart.DisplayShoppingCart(customerOrder);
                        //Display payment options, choose payment, process payment
                        break;
                    case MenuEnum.Quit:
                        Console.WriteLine("Bye!");
                        userWantsToQuit = true;
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }

                Console.WriteLine("\n... press any key to continue ...");
                Console.ReadKey();

            } while (userWantsToQuit.Equals(false));

            Console.ReadLine();
        }


    }
}
