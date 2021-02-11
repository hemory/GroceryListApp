using System;
using System.Collections.Generic;
using System.ComponentModel.Design;


namespace Sand_Box
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> groceryList = new List<string> { "eggs", "bacon", "zukes" };
            
            bool returnToMain = true;
            while (returnToMain)
            {
                Console.Write("[1]Add Item [2]Remove Item [3]View List: ");
                string menuSelection = Console.ReadLine();

                switch (menuSelection)
                {
                    case "1":

                        Console.Write("Number of Items: ");
                        int numOfItemsToAdd = int.Parse(Console.ReadLine());

                        for (int i = 0; i < numOfItemsToAdd; i++)
                        {
                            Console.Write($"Item {i}: ");
                            groceryList.Add(Console.ReadLine().ToLower()); //talk
                        }

                        break;

                    case "2":

                        bool keepGoing = true;
                        while (keepGoing)
                        {
                            Console.Write("Item: ");

                            string itemToRemove = Console.ReadLine().ToLower(); //talk


                            bool didRemove = groceryList.Remove(itemToRemove);

                            if (didRemove)
                            {
                                Console.WriteLine($"{itemToRemove} was removed from list.");
                            }
                            else
                            {
                                Console.WriteLine($"{itemToRemove} was not removed from list.");
                            }

                            Console.Write("Remove another item? Y or N: ");
                            string choiceToRemoveAnother = Console.ReadLine().ToLower();

                            if (choiceToRemoveAnother != "y")
                            {
                                keepGoing = false;
                            }
                        }

                        break;

                    case "3":
                       //call method
                       PrintList(groceryList);

                        break;

                    default:
                        Console.WriteLine("Please choose a valid option.");
                        continue;
                }

                Console.Write("Return to Main Y or N: ");
                string userMainChoice = Console.ReadLine().ToLower();

                if (userMainChoice != "y")
                {
                    returnToMain = false;
                }

            }

            Console.WriteLine("Press ENTER to Exit");
            Console.ReadLine();

        }

        public static void PrintList(List<string> groceryList)
        {
            Console.WriteLine("The List:");
            Console.WriteLine("---------");

            int countDisplay = 1;

            foreach (var item in groceryList)
            {
                Console.WriteLine($"{countDisplay}: {item} ");
                countDisplay++;
            }

            Console.WriteLine("---------");
        }



    }
}
