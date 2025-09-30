namespace LCO2Day02;

public class Day02Task3
{
    public static void Run()
    {
        int year1 = 2000;
        int year2 = 2024;
        int year3 = 1900;
        
        IsLeapYear(year1);
        IsLeapYear(year2);
        IsLeapYear(year3);
    }

    public static void IsLeapYear(int year)
    {
        bool isLeap = false;
        if (year % 4 == 0)
        {
            if (year % 100 != 0)
            {
                isLeap = true;
            }
            if (year % 400 == 0)
            {
                isLeap = true;
            }
        }

        if (isLeap)
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
        return;
    }
}