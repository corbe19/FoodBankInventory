﻿using FoodBankInventory;
using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

internal class Program
{
    private static List<FoodItem> foodList = new List<FoodItem>();

    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Food Bank Inventory System\n");
        Console.WriteLine("What would you like to do?");

        int choice = 0;


        while (choice != 4)
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Add a food item");
            Console.WriteLine("2. Remove a food item");
            Console.WriteLine("3. Print the food list");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddFoodItem();
                        break;
                    case 2:
                        RemoveFoodItem();
                        break;
                    case 3:
                        PrintFoodList();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    public static void AddFoodItem()
    {
        Console.WriteLine(); //readability

        Console.WriteLine("Enter the name of the food item: ");
        string name = Console.ReadLine().ToLower();

        Console.WriteLine("Enter the category of the food item: ");
        string category = Console.ReadLine();

        //negative number error handling
        int quantity = -1;
        while (quantity < 0)
        {
            Console.WriteLine("Enter the quantity of the food item (must be 0 or greater): ");
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }

        Console.WriteLine("Enter the expiration date of the food item: ");
        string expirationDate = Console.ReadLine();

        FoodItem foodItem = new FoodItem(name, category, quantity, expirationDate);
        foodList.Add(foodItem);
    }

    public static void RemoveFoodItem()
    {
        Console.WriteLine(); //readability

        Console.WriteLine("Enter the name of the food item you would like to remove: ");
        string name = Console.ReadLine().ToLower();
        for (int i = 0; i < foodList.Count; i++)
        {
            if (foodList[i].name == name)
            {
                foodList.RemoveAt(i);
                Console.WriteLine("Food item removed successfully.");
                return;
            }
        }
        Console.WriteLine("Food item not found.");
    }

    public static void PrintFoodList() {

        Console.WriteLine(); //Im just doing this to make a new line for readability

        if (foodList.Count == 0) { 
            Console.WriteLine("Inventory Empty");
        }

        for (int i = 0; i < foodList.Count; i++)
        {
            Console.WriteLine(foodList[i].ToString());
        }
    }

}