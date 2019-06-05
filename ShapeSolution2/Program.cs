using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolution2

{
    class ShapeSolution2
    {
        public static int Menu()
        {
            string getUserInput = "";
            bool flagSet = false;
           
            while (flagSet == false)
            {
                Console.WriteLine("Choose any one");
                Console.WriteLine("1. To enter values for sides of triangle ");
                Console.WriteLine("2. To get EXIT");

                Console.WriteLine("Enter your choice - ");
                getUserInput = Console.ReadLine();

                if (getUserInput != "1" &&
                     getUserInput != "2")
                {
                    Console.WriteLine("Invalid menu input option. Please try again");
                }
                else
                {
                    flagSet = true;
                }
            }
            return int.Parse(getUserInput);
        }
        public static int SanitizeUserInput(string inputNumber)
        {
            int aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {inputNumber}:");
                string getUserInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(getUserInput, out aNumber);

                if ((result == false) || !(aNumber>0))
                {
                    Console.WriteLine("That's not a valid input, please try again.\n");
                }
                else
                {
                    isValid = true;
                }

            }
            return aNumber;
        }

        public static void Main(string[] arg)
        {
            int flag = 0;
            do
            {
                switch (Menu())
                {
                    case 1:
                        int k = SanitizeUserInput("first side");
                        int m = SanitizeUserInput("second side");
                        int p = SanitizeUserInput("third side");
                        Console.WriteLine(TriangleSolver.Analyze(k, m, p));
                        break;
                    case 2:
                        flag = 1;
                        Environment.Exit(0);
                        break;
                }
            } while (flag == 0);
        }
    }
}