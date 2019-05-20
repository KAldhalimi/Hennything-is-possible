﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hennythingIsPossible
{
    public class Controller
    {

        List<Liquor> menu = new List<Liquor>();
        MenuView obj;
        ConsoleColor color;
        public Controller()
        {
            menu.Add(new Liquor("Malibu Carbiean Rum", "Rum", "", 21.99));
            menu.Add(new Liquor("Captain Morgan Spiced Rum", "Rum", "", 31.99));
            menu.Add(new Liquor("Bacardi Rum Superior", "Rum", "", 21.00));
            menu.Add(new Liquor("Zaya Gran Reserva Rum", "Rum", "", 31.00));
            menu.Add(new Liquor("Havan Club Anejo", "Rum", "", 21.99));
            menu.Add(new Liquor("Titos Handmade Vodka", "Vodka", "", 13.00));
            menu.Add(new Liquor("Grey Goose", "Vodka", "", 32.00));
            menu.Add(new Liquor("Smirnoff Vodka", "Vodka", "", 10.50));
            menu.Add(new Liquor("Absolute Vodka", "Vodka", "", 23.00));
            menu.Add(new Liquor("Ketel One", "Vodka", "", 23.00));
            menu.Add(new Liquor("Hendricks Gin", "Gin", "", 31.99));
            menu.Add(new Liquor("Bombay Sapphire", "Gin", "", 21.99));
            menu.Add(new Liquor("Tanqueray Gin London Dry", "Gin", "", 21.99));
            menu.Add(new Liquor("Beefeather London Dry", "Gin", "", 24.99));
            menu.Add(new Liquor("Seagrams Extra Dry", "Gin", "", 27.00));
            menu.Add(new Liquor("Clase Azul Reposado", "Tequila", "", 31.00));
            menu.Add(new Liquor("Don Julio", "Tequila", "", 41.99));
            menu.Add(new Liquor("Patron Silver", "Tequila", "", 35.00));
            menu.Add(new Liquor("Corralejo Reposado", "Tequila", "", 48.00));
            menu.Add(new Liquor("Cazadoej Reposado", "Tequila", "", 36.50));
            menu.Add(new Liquor("Remy Martin", "Brandy", "", 53.00));
            menu.Add(new Liquor("Hennessy Cognac", "Brandy", "", 33.00));
            menu.Add(new Liquor("Courvoisier Cognac", "Brandy", "", 41.99));
            menu.Add(new Liquor("Paul Masson", "Brandy", "", 21.99));
            menu.Add(new Liquor("St.Remy VSOP", "Brandy", "", 21.99));
            menu.Add(new Liquor("Jack Daniels", "Whiskey", "", 21.00));
            menu.Add(new Liquor("The Glenliver Scotch", "Whiskey", "", 51.00));
            menu.Add(new Liquor("Crown Royal", "Whiskey", "", 21.99));
            menu.Add(new Liquor("Johnnie Walker", "Whiskey", "", 33.00));
            menu.Add(new Liquor("Jameson Irish Whiskey", "Whiskey", "", 32.00));
            menu.Add(new Liquor("Smirnoff Vodka", "Vodka", "", 21.50));
            obj = new MenuView(menu);
            obj.DisplayMenu();
            Console.WriteLine();
            Order();
        }

        public void Order()
        {
            List<OrderedItems> OrderedItems = new List<OrderedItems>();//list of ordered items
            bool orderAgain = true;
            while (orderAgain)
            {
                int quantityPerItem = 0;
                int choice;
                //Present a menu to the user and let them choose an item(by number orletter).

                Console.WriteLine("What would you like to order?");
                Console.WriteLine();
                Console.WriteLine("Please choose an item by a number or by a name:");
                var userInput = Console.ReadLine(); // I used(var) because We dont know if the user will enter a number or a string
                bool gotValue = int.TryParse(userInput, out choice);
                if (gotValue == true) //that mean the user choose  an item from the menu by it's number
                {
                    //there are 31 items in the menu (the number should be 1 >= 1 and numbe <= 31 )
                    if (choice >= 1 && choice <= 31)
                    {
                    // Allow the user to choose a quantity for the ordered item.
                    QuentityCheck:
                        {

                            Console.WriteLine("Please enter the quantity: ");
                            bool gotQuanttity = int.TryParse(Console.ReadLine(), out quantityPerItem);
                            if (gotQuanttity == false)//if the  user didn't enter a number
                            {

                                Console.WriteLine("you entered unvalid number for quantity!!");
                                goto QuentityCheck;// give the user a nother chance to choose a valid number for quantity
                            }
                        }
                        OrderedItems.Add(new OrderedItems(menu[choice - 1].Name, menu[choice - 1].Price, quantityPerItem));
                    }
                    else//the user entered a number that is not in the list
                    {

                        Console.WriteLine("This number is not in the menu!!");
                        continue;// give the user a nother chance to choose from the menu
                    }
                }
                else // that mean the user choosed an item from the menu by it's name
                {
                    // check if the item name is in the menu
                    bool findItem = false;
                    double pricePerItem = 0;
                    foreach (Liquor L in menu)
                    {
                        if (userInput == L.Name)
                        {
                            findItem = true;//the item is in the menu
                            pricePerItem = L.Price;
                        }
                    }
                    if (findItem == true)
                    {
                    quantityCheck:

                        {

                            Console.WriteLine("Please enter the quantity: ");
                            bool gotQuanttity = int.TryParse(Console.ReadLine(), out quantityPerItem);
                            if (gotQuanttity == false)//if the  user didn't enter a number ex string or a character
                            {

                                Console.WriteLine("you entered unvalid number for quantity!!");
                                goto quantityCheck;// give the user a nother chance to choose a valid number for quantity
                            }
                            OrderedItems.Add(new OrderedItems(userInput, pricePerItem, quantityPerItem));
                        }
                    }
                    else if (findItem == false)// we don't have this iteam in the menu
                    {

                        Console.WriteLine("Sorry we don't have " + userInput);
                        Console.WriteLine("Please try again");
                        continue;
                    }
                }
            }
        }

    }
}

