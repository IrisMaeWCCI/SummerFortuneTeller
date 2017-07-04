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
         
            //Part 1
            Console.WriteLine("Welcome to your Fortune Teller!\nLet's get started\n\nWhat is your first name?");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("\nWhat is your last name?");
            string lastName = Console.ReadLine().ToLower();
            string fullName = firstName + lastName;

            Console.WriteLine("\nWhat is your age?");
            int age = int.Parse(Console.ReadLine());
            if (age>0 || age<131)
            {
                Console.WriteLine();
            }
            else if (0 > age || 130 < age)
            {
                Console.WriteLine("\nPlease enter an age between 1 and 130, "+firstName);
                 age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease enter your birth month as a two digit number");
            int birthMonth = int.Parse(Console.ReadLine());
            if (01 <= birthMonth || 12 >= birthMonth)
            {
                Console.WriteLine("\n" + birthMonth + "? Cool!");
            }
            else if (birthMonth<01 || 12 < birthMonth)
            {
                Console.WriteLine("\nPlease enter a month between 1 and 12, " + firstName);
                birthMonth = int.Parse(Console.ReadLine());
            }
            //getting this if statement to work has been so annoying. still isn't working the way i want it to
            //must set aside time later to work it out 

            Console.WriteLine("\nWhich is your favorite of the ROYGBIV colors? Type help if you do not know what ROYGBIV means");
            string userROYGBIVResponse = Console.ReadLine().ToLower();

            if (userROYGBIVResponse == "help".ToLower())
            {
                Console.WriteLine("R: Red\nO: Orange\nY: Yellow\nG: Green\nB: Blue\nI: Indigo\nV: Violet\n");
                Console.WriteLine("Which is your favorite ROYGBIV color?");
                userROYGBIVResponse = Console.ReadLine();

                if (userROYGBIVResponse == "help" || userROYGBIVResponse == "red" || userROYGBIVResponse == "orange" || userROYGBIVResponse == "yellow" || userROYGBIVResponse == "blue" || userROYGBIVResponse == "indigo" || userROYGBIVResponse == "violet")

                {
                    Console.WriteLine("Sweet, I like " + userROYGBIVResponse + " too!");
                }
                else
                {
                    Console.WriteLine("\nPlease restart the program and try again.");
                }
            }
            Console.WriteLine("\nHow many siblings do you have");
            int userAmountOfSiblings = int.Parse(Console.ReadLine());

            //Part 2
            //Part 3- Print User Info

            //User Fortune Results Are Printed Below

            //Retirement is age dependant
            int retirementAge = age % 2;
            if (retirementAge != 0)
            {
                Console.WriteLine("\n"+fullName +" you are " + age + " years old, yet will retire in" + age + " years");
            }
            else
            {
                Console.WriteLine("\n"+fullName + ", you are " + age + " years old and you will most assuredly retire in " + (age + 10) + " years");
            }

            //BirthMonth and $ in Bank

            if ( 01>= birthMonth  || birthMonth >= 04)
            {
                Console.WriteLine("\nYou will have $275000 in the bank!");
            }
            else if (05 >= birthMonth || birthMonth >= 08)
            {
                Console.WriteLine("\nYou will have $2,570,000 in the bank!");
            }
            else if (09 >= birthMonth || birthMonth >= 12)
            {
                Console.WriteLine("\nYou will have $2,750 in the bank!");
            }
            else
            {
                Console.WriteLine("\nYou entered a number I cannot see would ever be in your fortune, therefore you will have $0.00 in the bank!");
            }

            //Sibling # and vacation home

            if (userAmountOfSiblings == 0)
            {
                Console.WriteLine("\nAlmost as if you're stepping out of a dream, a vacation home\nin Manhattan will be given to you quickly and effortlessly!");
            }
            else if (userAmountOfSiblings == 1)
            {
                Console.WriteLine("\nYou will miraculously a vacation home will be in Monte Carlo!");
            }
            else if (userAmountOfSiblings == 2)
            {
                Console.WriteLine("\nYou now have a vacation home will be in Moscow!");
            }
            else if (userAmountOfSiblings == 3)
            {
                Console.WriteLine("\nYou will mysteriously obtain a vacation home will be in Michoacán!");
            }
            else if (userAmountOfSiblings == 1)
            {
                Console.WriteLine("\nSoon you will possess a vacation home will be in Miami");
            }
            else if (userAmountOfSiblings < 0)
            {
                Console.WriteLine("\nYour vacation home will be in your garage!");
            }

            Console.WriteLine(birthMonth);
            
            // ROYGBIV and transportation
            if (userROYGBIVResponse=="red")
            {
                Console.WriteLine("\nYour new mode of transportation will be a red Audi!");
            }
            else if (userROYGBIVResponse =="orange")
            {
                Console.WriteLine("\nYour new mode of transportation will be an orange bicycle!");
            }
            else if (userROYGBIVResponse =="yellow")
            {
                Console.WriteLine("\nYour new sole mode of transportation will be your feet-you're getting a pair of yellow TOMS shoes!");
            }
            else if (userROYGBIVResponse =="blue")
            {
                Console.WriteLine("\nAs a new mode of transportation you'll be getting around using a blue pogo stick!");
            }
            else if (userROYGBIVResponse =="indigo")
            {
                Console.WriteLine("\nYou'll have an indigo skate board to get around from now on!");
            }
            else if (userROYGBIVResponse =="violet")
            {
                Console.WriteLine("\nYou're now the proud owner of a violet BMW!");
            }
            else 
            {
                Console.WriteLine("\nFollow directions next time! Try again.");
            }

            //Allow the user to quit at any point this is my stretch task
            //print nobody likes a quitter before the program quits

            //User Quits Option
            Console.WriteLine("\n"+firstName+", you can quit at any time by typing quit");
            string userQuits = Console.ReadLine();

            if (userQuits == "quit")
            {
                Console.WriteLine("\nNobody likes a quitter, "+firstName);
                return;

            }
            else
            {
                Console.WriteLine("\nWe're glad you stayed; restart the program to have your fortune revealed to you once again...");
            }
        }
    }
}
