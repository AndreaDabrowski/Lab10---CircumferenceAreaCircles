using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {

        static void Main(string[] args)
        {
            string response;
            int counter = 1;
            while (true) 
            {
                Console.WriteLine("LETS FIND THE CIRCUMFERENCE AND AREA OF A CIRCLE!");
                double radius = ValidateRadius();//prompts user and validates correct format

                Circle myCircle = new Circle(radius);//sets radius to user input

                Console.WriteLine($"Circumference: {myCircle.CalculateCircumference()}"); //user mycircle called circumference method
                Console.WriteLine($"Circumference formatted: {myCircle.CalculateFormattedCircumference()}");//called formatted circumference method

                Console.WriteLine($"Area: {myCircle.CalculateArea()}");//calculates area
                Console.WriteLine($"Area Formatted: {myCircle.CalculateFormattedArea()}");//calculates formatted area

                Console.WriteLine("Would you like to continue? (y/n)");
                response = Console.ReadLine().ToLower();
                if (YesOrNo(response) == true)
                {
                    counter++;//increases total number of calculated circles with each "y" response
                }
                else
                {
                    break;
                }


            }
            Console.WriteLine("GoodBye! You created {0} Circles!", counter); //, VALUE);
            Console.ReadLine();
            
        }
        //verifies correct format for y or n responses
        public static bool YesOrNo(string response)
        {

            while (true)
            {

                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.Write("Invalid input, try (y/n): ");
                    response = Console.ReadLine().ToLower();//changes variable and loops to top

                }
            }

        }
        public static double ValidateRadius()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the circle's radius: ");
                    double num = double.Parse(Console.ReadLine());
                    return num;

                }
                catch (FormatException)//throws exception for format issues
                {
                    Console.Write("Invalid Format - Input valid number: ");
                }
            }
        }
    }
}
