using System;

namespace LCO2Day04;

public class Program
{
    static void Main(string[] args)
    {
        bool run;
        do
        {
            Console.Write("Run which program? [1-14?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Day04Task1.Run();
                    break;
                case "2":
                    Day04Task2.Run();
                    break;
                case "3":
                case "4":
                    Day04Task3.Run();
                    break;
                case "5":
                    Console.WriteLine("This is task 5!");
                    break;
                case "6":
                    Day04Task6.Run();
                    break;
                case "7":
                    Day04Task7.Run();
                    break;
                case "8":
                    Day04Task8.Run();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            
            Console.Write("\nRun another program [y/n]? ");
            run = Console.ReadLine().ToLower() == "y";
        } while (run);
    }
}