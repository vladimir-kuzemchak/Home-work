using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032021Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even or not even 

            int userNumber = 0;

            Console.Write("Enter number: ");

            while(!int.TryParse(Console.ReadLine(),out userNumber))
            {
                Console.Write("[Exception] Try again: ");
            }

            if ((userNumber & 1) == 1)
            {
                Console.Write("Number is not even");
            }
            else
            {
                Console.Write("Number is even");
            }

            Console.WriteLine();

        }
    }
}
