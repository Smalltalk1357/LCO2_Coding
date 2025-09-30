namespace LCO2Day04;
// Updated to use the box drawing characters

public class Day04Task3
{
    public static void Run()
    {
        DrawTable(2, 3, 6, 1);
    }

    public static void DrawTable(int row= 5, int col = 5, int cellWidth = 5, int cellHeight = 1)
    {
        Console.Clear();
        // NB for square(ish) cells, width = 5 x height
        // cellWidth *= 5;
        
        DrawBorder(col, cellWidth, '┌', '─','┬', '┐');
        for (int colIndex = 0; colIndex < cellHeight; colIndex++)
        {
            DrawBorder(col, cellWidth, '│', ' ','│', '│');
        }
        for (int rowIndex = 0; rowIndex < (row - 1); rowIndex++)
        {
            DrawBorder(col, cellWidth, '├', '─','┼', '┤');
            for (int colIndex = 0; colIndex < cellHeight; colIndex++)
            {
                DrawBorder(col, cellWidth, '│', ' ','│', '│');
            }
        }

        DrawBorder(col, cellWidth, '└', '─','┴', '┘');

    }

    private static void DrawBorder(int noColumns, int colWidth, char start, char spacer, char middle, char end)
    {
        string cellBorder = new string(spacer, colWidth);
        
        Console.Write(start + cellBorder);

        for (int colIndex = 0; colIndex < (noColumns - 1); colIndex++)
        {
            Console.Write(middle + cellBorder);
        }

        Console.WriteLine(end);
    }
}