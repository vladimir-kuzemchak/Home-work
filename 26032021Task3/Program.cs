using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032021Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3:Count the number 1 whitout string 

            int userNumber = 0;

            Console.Write("Enter number:");

            while(!int.TryParse(Console.ReadLine(),out userNumber))
            {
                Console.Write("[Exception] Try again: ");
            }

            int bitsNumber = 0;
            while (userNumber != 0)
            {
                bitsNumber++;
                userNumber = userNumber & (userNumber - 1);
            }

            Console.Write($"Bits count:{bitsNumber}");
            Console.WriteLine();

        }
    }
}
