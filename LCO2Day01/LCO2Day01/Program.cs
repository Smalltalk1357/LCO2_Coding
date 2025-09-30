namespace LCO2Day01;

public class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        while (run)
        {
            Console.Write("Select program to run [1 - 4]: ");
            string selection = Console.ReadLine();
            
            if (selection == "1")
            {
                Day01Task1.Run();
            }
            else if (selection == "2")
            {
                Day01Task2.Run();
            }
            else if (selection == "3")
            {
                Day01Task3.Run();
            }
            else if (selection == "4")
            {
                Day01Task3Ext.Run();
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
            
            Console.Write("\n----------\nSelect another program? [y/n]: ");
            selection = Console.ReadLine();
            if (selection == "n")
                run = false;
        }
    }
}