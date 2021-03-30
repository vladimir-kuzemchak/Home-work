using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1: traning schedule

            string input = string.Empty;

            const byte MASK_00 = (byte)0x00; // Clear variable
            const byte MASK_01 = (byte)0x01; // Monday
            const byte MASK_02 = (byte)0x02; // Tuesday
            const byte MASK_04 = (byte)0x04; // Wednesday
            const byte MASK_08 = (byte)0x08; // Thursday
            const byte MASK_10 = (byte)0x10; // Friday
            const byte MASK_12 = (byte)0x20; // Saturday
            const byte MASK_14 = (byte)0x40; // Sunday

            byte userSchedule = MASK_00;

            do
            {
                Console.Write("1 - Show all schedule\n" +
                              "2 - Write new schedule\n" +
                              "3 - Clear all schedule\n" +
                              "0 - Exit\n");
                Console.Write("Select Item:");

                input = Console.ReadLine();

                input = input.Replace(" ","");

                switch (input)
                {

                    case "1":

                        if (userSchedule == 0)
                        {
                            Console.Write("Schedule are empty");

                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }

                        if ((userSchedule & MASK_01) > 0)
                        {
                          
                            Console.WriteLine("You have training in Monday");
                        }

                        if ((userSchedule & MASK_02) > 0)
                        {
                           
                            Console.WriteLine("You have training in Tuesday");
                        }

                        if ((userSchedule & MASK_04) > 0)
                        {
                            Console.WriteLine("You have training in Wednesday");
                        }

                        if ((userSchedule & MASK_08) > 0)
                        {
                            Console.WriteLine("You have training in Thursday");
                        }

                        if ((userSchedule & MASK_10) > 0)
                        {
                            Console.WriteLine("You have training in Friday");
                        }

                        if ((userSchedule & MASK_12) > 0)
                        {
                           
                            Console.WriteLine("You have training in Saturday");
                        }

                        if ((userSchedule & MASK_14) > 0)
                        {
                            Console.WriteLine("You have training in Sunday");
                        }

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "2":
                        Console.Clear();

                        string userChoice = string.Empty;

                        Console.Write("There is a workout in Monaday?(yes/no):");
                        userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "y")
                        {
                            userSchedule = (byte)(userSchedule | MASK_01);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                        }
                      
                        Console.Write("There is a workout in Tuesday?(yes/no):");
                        userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "y")
                        {
                            userSchedule = (byte)(userSchedule | MASK_02);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                        }

                        Console.Write("There is a workout in Wednesday?(yes/no):");
                        userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "y")
                        {
                            userSchedule = (byte)(userSchedule | MASK_04);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                        }

                        Console.Write("There is a workout in Thursday?(yes/no):");
                        userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "y")
                        {
                            userSchedule = (byte)(userSchedule | MASK_08);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                        }

                        Console.Write("There is a workout in Friday?(yes/no):");
                        userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "y")
                        {
                            userSchedule = (byte)(userSchedule | MASK_10);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                        }

                        Console.Write("There is a workout in Saturday?(yes/no):");
                        userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "y")
                        {
                            userSchedule = (byte)(userSchedule | MASK_12);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                        }

                        Console.Write("There is a workout in Sunday?(yes/no):");
                        userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "y")
                        {
                            userSchedule = (byte)(userSchedule | MASK_14);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                        }

                        Console.Clear();

                        break;

                    case "3":

                        if (userSchedule == 0)
                        {
                            Console.Write("Schedule are empty");

                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }
                        else
                        {
                            userSchedule = MASK_00;
                            Console.WriteLine("Schedule cleared");

                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;
                    
                    default:
                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("[Exception] Wrong input, the line must contain characters");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            if (input == "0")
                            {
                                continue;   
                            }
                            Console.WriteLine("Wrong input,try again");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        
                        break;
                }
            }
            while (input != "0");

        }
    }
}
