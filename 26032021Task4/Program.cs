using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032021Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 4: Display symbols without string

            int userNumber = 0;

            Console.Write("Enter number: ");

            while(!int.TryParse(Console.ReadLine(),out userNumber))
            {
                Console.Write("[Exception] Try,again: ");   
            }

            string outputString = string.Empty;
            while (userNumber > 0)
            {

                if (userNumber % 2 == 0)
                {
                    outputString = outputString + "0";
                }
                else
                {
                    outputString = outputString + "1";
                }

                userNumber /= 2;
            }
            
            Console.Write($"User output:     {outputString} \n");

            Console.Write($"Built-in output: {outputString,2:X}");

            Console.WriteLine();
            



        }
    }
}
