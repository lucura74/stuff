using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modernMedical
{
    class Program
    {
        /************************************************************
         * Program checks numbers 1-100 to see if they are divisible
         * by 3 and 5.  Outputs "Modern" to the console if divisible
         * by 3, "Medical" if divisible by 5, and the number as a 
         * string if neither is true.
         * **********************************************************/
        
        static void Main(string[] args)
        {
            int number;
            string output = String.Empty;

            for (number = 1; number < 101; number++)
            {
                DivideByThree(number, ref output);
                DivideByFive(number, ref output);
                ConfigureOutput(number, ref output);              
                output = String.Empty;
            }

            Console.ReadLine();
        }

        /**************************************************************
         * ConfigureOutput method:
         * reads the output string variable, assigns a number to it if
         * empty, and prints the output variable to the screen.
         * ***********************************************************/

        private static void ConfigureOutput(int number, ref string output)
        {
            if (output == String.Empty)
            {
                output = number.ToString();
            }
            Console.WriteLine(output);
            return;
        }

        /*************************************************************
         * DivideByFive method:
         * divides the input number by five and looks for a remainder of 0.
         * If remainder is 0, it modifies the output string.
         * ***********************************************************/

        private static void DivideByFive(int number, ref string output)
        {
            int remainder = number % 5;
            string med = "Medical";

            if (remainder == 0)
            {
                output = output + med;
            }
            return;
        }

        /*************************************************************
        * DivideByThree method:
        * divides the input number by three and looks for a remainder of 0.
        * If remainder is 0, it modifies the output string.
        * ***********************************************************/
        private static void DivideByThree(int number, ref string output)
        {
            int remainder = number % 3;
            string modern = "Modern";

            if (remainder == 0)
            {
                output = output + modern;
            }
            return;
        }
    }
}
