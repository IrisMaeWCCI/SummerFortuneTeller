using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Welcome to your Fortune Teller!\nLet's get started\nWhat is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string fullName = firstName + lastName;

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your birth month as a two digit number");
            int birthMonth = int.Parse(Console.ReadLine());
            */
            Console.WriteLine("Which is your favorite of the ROYGBIV colors?");
            string userROYGBIVResponse = Console.ReadLine();

            if (userROYGBIVResponse == "help".ToLower())
            {
                Console.WriteLine("R: Red\nO: Orange\nY: Yellow\nG: Green\nB: Blue\nI: Indigo\nV: Violet");
                Console.WriteLine("Which is your favorite of the ROYGBIV colors?");
                if (userROYGBIVResponse != "help")
                {
                    Console.WriteLine("Please restart the program and try again.");
                }
            }
            else if (userROYGBIVResponse == "red" || userROYGBIVResponse == "orange" || userROYGBIVResponse == "yellow" || userROYGBIVResponse == "blue" || userROYGBIVResponse == "indigo" || userROYGBIVResponse == "violet")
            {
                Console.WriteLine("Sweet, I like " + userROYGBIVResponse + " too!");
            }

            Console.WriteLine("How many siblings do you have");
            string userAmountOfSiblings = Console.ReadLine();
        }

    }
}
