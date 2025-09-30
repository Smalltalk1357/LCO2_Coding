namespace LCO2Day02;

public class Day02Task11
{
    public static void Run()
    {
        Console.Write("Enter quiz score (%): ");
        float quizScore = Convert.ToSingle(Console.ReadLine());
        
        Console.Write("Enter block test score (%): ");
        float blockTest = Convert.ToSingle(Console.ReadLine());
        
        Console.Write("Enter final test score (%): ");
        float finalTest = Convert.ToSingle(Console.ReadLine());
        
        
        Console.WriteLine($"Final Grade: {CalcGrade(quizScore, blockTest, finalTest)}");
    }

    public static string CalcGrade(float quizScore, float blockTest, float finalTest)
    {
        double totalScore = quizScore + blockTest + finalTest;
        double average = totalScore / 3;
        string grade = "";
        {
            switch (average)
            {
                case (<50):
                    grade = "F";
                    break;
                case (<70):
                    grade = "C";
                    break;
                case (<80):
                    grade = "B";
                    break;
                case (<90):
                    grade = "A";
                    break;
                case (>=90):
                    grade = "A*";
                    break;
            }
        }
        return grade;
    }
}