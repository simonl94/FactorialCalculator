using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number"); //Gets a user input
            int number = Convert.ToInt32(Console.ReadLine()); //Converts input to string
            long fact = GetFactorial(number); //Call method and give it the long data type

            Console.WriteLine("{0} factorial is {1}", number, fact); //Prints result 
            Console.ReadKey(); //Waits for user input
        }

        private static long GetFactorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            return i * GetFactorial(i - 1); //Factorial logic
        }
    }
}

