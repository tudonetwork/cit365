using System;
/*
@description: Frist Applicacion in C#
@author: Ramon Andrade
*/

namespace ConsoleApplicationAndrade
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables with my name and location
            String Name = "Ramon";
            String Location = "Brazil";

            // Getting Today's date
            DateTime today = DateTime.Today;

            // Setting Christmas's date
            DateTime christmas = new DateTime(2019, 12, 25);

            // Compare number of day between today and christmas
            int numDays = (christmas - today).Days;


            // Printing the results with interpolated string

            Console.WriteLine($"My name is {Name}\n");

            Console.WriteLine($"I'm from  {Location}!");

            Console.WriteLine("\n-------\n");
           
            Console.WriteLine($"It's {today:M/d/yyyy} today, and left {numDays} days until Christmas!");


            Console.WriteLine("\n--- GlazerCalc ----\n");


            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please, provide the width of the wood:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please, provide the height of the wood:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("\nThe length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");


        }
    }
}
