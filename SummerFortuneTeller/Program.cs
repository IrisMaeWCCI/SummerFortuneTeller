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
        {
            Console.WriteLine("Welcome to your Fortune Teller!\nLet's get started\nWhat is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string fullName = firstName + lastName;

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your birth month as a two digit number");
            int birthMonth = int.Parse(Console.ReadLine());
            //getting this if statement to work has been so annoying. still isn't working the way i want it to
            //must set aside time later to work it out 
            Console.WriteLine("Which is your favorite of the ROYGBIV colors? Type help if you do not know what ROYGBIV means");
            string userROYGBIVResponse = Console.ReadLine();

            if (userROYGBIVResponse == "help".ToLower())
            {
                Console.WriteLine("R: Red\nO: Orange\nY: Yellow\nG: Green\nB: Blue\nI: Indigo\nV: Violet");
                // Console.WriteLine("Which is your favorite of the ROYGBIV colors?");
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
            int userAmountOfSiblings = int.Parse(Console.ReadLine());

            if (age % 2 != 0)
            {
                Console.WriteLine("You are " + age + " years old and will retire in" + age + " years");
            }
            else
            {
                Console.WriteLine("You are " + age + " years old and you will retire in" + (age + 10) + " years");
            }
            if (userAmountOfSiblings == 0)
            {
                Console.WriteLine("You're vacation home will be in Manhattan!");
            }
            else if (userAmountOfSiblings == 1)
            {
                Console.WriteLine("You're vacation home will be in Monte Carlo!");
            }
            else if (userAmountOfSiblings == 2)
            {
                Console.WriteLine("You're vacation home will be in Moscow!");
            }
            else if (userAmountOfSiblings == 3)
            {
                Console.WriteLine("You're vacation home will be in Michoacán!");
            }
            else if (userAmountOfSiblings == 1)
            {
                Console.WriteLine("You're vacation home will be in Miami");
            }
            else if (userAmountOfSiblings < 0)
            {
                Console.WriteLine("You're vacation home will be in your garage!");
            }

            Console.WriteLine("How many siblings do you have");
//ROYGBIV mode of transportation
            if (userROYGBIVResponse=="red")
            {
                Console.WriteLine("Ypu'll be driving an Audi!");
            }
            else if (userROYGBIVResponse =="orange")
            {
                Console.WriteLine("You'll be riding a bicycle!");
            }
            else if (userROYGBIVResponse =="yellow")
            {
                Console.WriteLine("You're gonna be walking my friend!");
            }
            else if (userROYGBIVResponse =="blue")
            {
                Console.WriteLine("You'll be getting around using a pogo stick!");
            }
            else if (userROYGBIVResponse =="indigo")
            {
                Console.WriteLine("You'll have a skate board to go from place to place from now on!");
            }
            else if (userROYGBIVResponse =="violet")
            {
                Console.WriteLine("You're now the proud owner of a BMW!");
            }
            else 
            {
                Console.WriteLine("Follow directions next time! Try again.");
            }

            if (birthMonth >=1|| birthMonth>==4)
            {
                Console.WriteLine("You will have $20 in the bank!");
            }
            else if (birthMonth >= 5 || birthMonth >= 8)
            {
                Console.WriteLine("You will have $2,000 in the bank!");
            }
            else if (birthMonth >= 9 || birthMonth >=12)
            {
                Console.WriteLine("You will have $2,000 in the bank!");
            }
            else 
            {
                Console.WriteLine("You will have $0.00 in the bank!");
            }
            //I need to calculate the amount of time it will take to retire so i need a variable for that
            // I need a to lower for each input from the user so different case wont be an issue later on
            //Allow the user to quit at any point this is my stretch task
            //print nobody likes a quitter before the program quits
        }
    }
}
