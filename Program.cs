using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture_5_Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //2.Write a program that prompts the capacity, in gallons, of an automobile fuel tank and the miles per gallon the automobile can be driven.The program outputs the number of miles the automobile can be driven without refueling.

            Console.Write("What is your tanks capacity: ");
            int tankCapacity = int.Parse(Console.ReadLine());

            Console.Write("How many miles per gallon: ");
            int mpg = int.Parse(Console.ReadLine()); ;

            int distanceCarCanTravel = tankCapacity * mpg;

            Console.WriteLine($"Your car can travel {distanceCarCanTravel} miles");

            Console.WriteLine();


        } // Main
        //-------------------------------------------------------------

        public static void InClassReview()
        {

        }

        public static void NestedIfExamples()
        {
            // Nested Ifs

            // const
            // constant
            const int AGE_TO_DRINK = 21;
            const int AGE_TO_DRIVE = 16;

            bool hasBeenDrinking = true;

            try
            {
                Console.WriteLine("What is your age?");
                string userAge = Console.ReadLine();
                int age = int.Parse(userAge);

                bool canDrink = age >= AGE_TO_DRINK;

                 // if (canDrink && !hasBeenDrink) { }

                if (canDrink)// True
                {

                    if (hasBeenDrinking) // True
                    {
                        Console.WriteLine("We cant serve your anymore");
                    }
                    else
                    {
                        Console.WriteLine("What would you like.");
                    }

                    Console.WriteLine("Have a good day");

                }
                else
                {
                    Console.WriteLine("Go find a dennys");
                }

                if (age > AGE_TO_DRIVE)
                {
                    Console.WriteLine("Have a good drive");
                }


            }
            catch
            {
                Console.WriteLine("Please enter a valid number.");
            }

        }

        // Method - Code Block


        public static void DebuggingExample()
        {
            // Debugging
            // Breakpoint - Located on left hand side in grey bar

            for (int i = 0; i < 30; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void Ternary()
        {

            //Console.WriteLine("Are you old enough to drink");
            //int age = int.Parse(Console.ReadLine());
            string course = "asdfsd";
            string teacher =
                (course == "night") ? "Will" :
                (course == "afternoon") ? "Lhoucine" :
                "Josh";

            Console.WriteLine(teacher);
        }

        public static void NestedIfs()
        {

        } // NestedIfs

        public static void LogicalOperators()
        {

            // Logical Operators
            bool isRaining = false;
            bool below50deg = true;

            // && and
            // || or
            // ! not
            //if (isRaining && below50deg)
            //{
            //    Console.WriteLine("Bring a jacket and umbrella");
            //}

            //if (isRaining || below50deg)
            //{
            //    Console.WriteLine("Check the weather first");
            //}

            Console.WriteLine((true && true) && !false == !true || false);


        } // LogicalOperators


    } // class
     
} // namespace
