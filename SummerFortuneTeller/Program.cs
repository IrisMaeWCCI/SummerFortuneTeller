﻿using System;
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
         
            //Part 1
            //Prompt User, Receive User Input
            //User Name
            Console.WriteLine("Welcome to your Fortune Teller!\nLet's get started\n\nWhat is your first name?");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("\nWhat is your last name?");
            string lastName = Console.ReadLine().ToLower();
            string fullName = firstName +" "+ lastName;

            //User Age
            Console.WriteLine("\nWhat is your age?");
            int age = int.Parse(Console.ReadLine());
            if (age>0 || age<131)
            {
                Console.WriteLine("");
            }
            else if (0 < age || 130 > age)
            {
                Console.WriteLine("\nPlease enter an age between 1 and 130, "+firstName);
                 age = int.Parse(Console.ReadLine());
            }

            //Birth Month
            Console.WriteLine("\nPlease enter your birth month as a two digit number, " + firstName);
            int birthMonth = int.Parse(Console.ReadLine());
            if (01 <= birthMonth || 12 >= birthMonth)
            {
                Console.WriteLine("");
            }
            else if (birthMonth<01 || 12 < birthMonth)
            {
                Console.WriteLine("\nPlease enter a month between 1 and 12, " + firstName);
                birthMonth = int.Parse(Console.ReadLine());
            }

            //ROGBIV 
            Console.WriteLine("\nWhich is your favorite of the ROYGBIV colors? Type help if you do not know what ROYGBIV means");
            string userROYGBIVResponse = Console.ReadLine().ToLower();

            if (userROYGBIVResponse == "help".ToLower())
            { 
                Console.WriteLine("R: Red\nO: Orange\nY: Yellow\nG: Green\nB: Blue\nI: Indigo\nV: Violet\n");
                Console.WriteLine("Which is your favorite ROYGBIV color?");
                userROYGBIVResponse = Console.ReadLine();
            }
            else if (userROYGBIVResponse == "red" || userROYGBIVResponse == "orange" || userROYGBIVResponse == "yellow" || userROYGBIVResponse == "blue" || userROYGBIVResponse == "indigo" || userROYGBIVResponse == "violet".ToLower())
            { 
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("\n\aPlease restart the program and try again.");
                return;
             }
            //Siblings
            Console.WriteLine("\nHow many siblings do you have");
            int userAmountOfSiblings = int.Parse(Console.ReadLine());

            //Part 2
            //Part 3- Print User Info

            //User Fortune Results Are Printed Below

            //Retirement is age dependant
            int retirementAge = age % 2;
            if (retirementAge != 0)
            {
                Console.WriteLine("\n\n\t"+fullName +" you are " + age + " years old, yet will retire in " + age + " years");
            }
            else
            {
                Console.WriteLine("\n\n\t"+fullName + ", you are " + age + " years old and you will most assuredly retire in " + (age + 10) + " years");
            }

            //BirthMonth and $ in Bank

            if ( 01>= birthMonth  || birthMonth >= 04)
            {
                Console.WriteLine("\n\tYou will have $275,000 in the bank!");
            }
            else if (05 >= birthMonth || birthMonth >= 08)
            {
                Console.WriteLine("\n\tYou will have $2,570,000 in the bank!");
            }
            else if (09 >= birthMonth || birthMonth >= 12)
            {
                Console.WriteLine("\n\tYou will have $2,750 in the bank!");
            }
            else
            {
                Console.WriteLine("\n\t\aYou have entered a number I cannot see would ever be in your fortune,\ttherefore you will have $0.00 in the bank!");
            }

            //Sibling # and vacation home

            if (userAmountOfSiblings == 0)
            {
                Console.WriteLine("\n\tAlmost as if you're stepping out of a dream, a vacation home\n\tin Manhattan will be given to you quickly and effortlessly!");
            }
            else if (userAmountOfSiblings == 1)
            {
                Console.WriteLine("\n\tYou will miraculously a vacation home will be in Monte Carlo!");
            }
            else if (userAmountOfSiblings == 2)
            {
                Console.WriteLine("\n\tYou now have a vacation home will be in Moscow!");
            }
            else if (userAmountOfSiblings == 3)
            {
                Console.WriteLine("\n\tYou will mysteriously obtain a vacation home will be in Michoacán!");
            }
            else if (userAmountOfSiblings == 1)
            {
                Console.WriteLine("\n\tSoon you will possess a vacation home will be in Miami");
            }
            else if (userAmountOfSiblings < 0)
            {
                Console.WriteLine("\n\t\aYour vacation home will be in your garage!");
            }
            
            // ROYGBIV and transportation
            if (userROYGBIVResponse=="red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tYour new mode of transportation will be a red Audi!");
                Console.ResetColor();
            }
            else if (userROYGBIVResponse =="orange")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;//this was as close to orange as it got!
                Console.WriteLine("\n\tYour new mode of transportation will be an orange bicycle!");
                Console.ResetColor();
            }
            else if (userROYGBIVResponse =="yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\tYour new mode of transportation will be your feet only-you're getting a \tpair of yellow TOMS shoes!");
                Console.ResetColor();
            }
            else if (userROYGBIVResponse == "green")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\tHappy travels on- you'll soon find you own a snazzy green moped!");
                Console.ResetColor();

            }
            else if (userROYGBIVResponse =="blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\tAs a new mode of transportation you'll be getting around using a blue pogo stick!");
                Console.ResetColor();
            }
            else if (userROYGBIVResponse =="indigo")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\tYou'll have an indigo skate board to get around from now on!");
                Console.ResetColor();
            }
            else if (userROYGBIVResponse =="violet")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n\tYou're now the proud owner of a violet BMW!");
                Console.ResetColor();
            }
            else 
            {
                Console.WriteLine("\n\t\aFollow directions next time! Try again.");
            }

            //Allow the user to quit at any point this is my stretch task
            //print nobody likes a quitter before the program quits

            //User Quits Option
            Console.WriteLine("\n\t" + firstName+", you can quit at any time just by typing quit\n\nSee ya 'round!");
            string userQuits = Console.ReadLine();

            if (userQuits == "quit")
            {
                Console.WriteLine("\n\t\aNobody likes a quitter, " + firstName);
                return;
            }
            else
            {
                Console.WriteLine("\n\tWe're glad you stayed; restart the program to have your fortune revealed to you once again...");
            }
        }
    }
}
