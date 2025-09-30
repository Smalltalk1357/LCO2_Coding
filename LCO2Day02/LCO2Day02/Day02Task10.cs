namespace Day02;

public class Day02Task10
{
    public static void Run()
    {
        List<float> coord = new List<float>();
        List<float> circleCoord = new List<float>();
        float radius = 0;
        
        Console.Write("Enter x coordinate: ");
        coord.Add(Convert.ToSingle(Console.ReadLine()));
        Console.Write("Enter y coordinate: ");
        coord.Add(Convert.ToSingle(Console.ReadLine()));
        
        Console.Write("Enter circle radius: ");
        radius = Convert.ToSingle(Console.ReadLine());
        
        Console.Write("Enter circle x coordinate: ");
        circleCoord.Add(Convert.ToSingle(Console.ReadLine()));
        Console.Write("Enter circle y coordinate: ");
        circleCoord.Add(Convert.ToSingle(Console.ReadLine()));
        
        EvalCoordinates(coord, radius, circleCoord);
    }
    
    public static void EvalCoordinates(List<float> coord, float radius, List<float> circleCoord)
    {
        float pointX = coord[0];
        float pointY = coord[1];
        float circleX = circleCoord[0];
        float circleY = circleCoord[1];
        
        int quadrant = 0;
        double hypotenuse = 0;
        double newHypotenuse = 0;
        bool inCircle = false;
        bool inCircle2 = false;
        
        // Quadrant
        switch (pointX, pointY)
        {
            case (>0, >0):
                quadrant = 1;
                break;
            case (<0, >0):
                quadrant = 2;
                break;
            case (>0, <0):
                quadrant = 3;  
                break;
            case (<0, <0):
                quadrant = 4;
                break;
        }
        
        // Radius
        
        hypotenuse = Math.Sqrt(Math.Pow(pointX, 2) + Math.Pow(pointY, 2));
        
        if (hypotenuse <= Math.Pow(radius, 2))
        {
            inCircle = true;
        }
        
        // Radius 2
        float xDiff = Math.Abs(circleX - pointX);
        float yDiff = Math.Abs(circleY - pointY);
        
        newHypotenuse = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));

        if (newHypotenuse <= Math.Pow(radius, 2))
        {
            inCircle2 = true;
        }
        
        Console.WriteLine($"Point is located in quadrant {quadrant}");
        switch (inCircle, inCircle2)
        {
            case (true, true):
                Console.WriteLine($"Point is inside circles with center (0,0) and ({circleX},{circleY})");
                break;
            case (false, false):
                Console.WriteLine("Point is outside both circles");
                break;
            case (true, false):
                Console.WriteLine("Point is inside circle with center (0,0)");
                break;
            case (false, true):
                Console.WriteLine($"Point is inside circle with center ({circleX},{circleY})");
                break;
        }
    }
}