using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter polygon vertices (x, y):");
        Point[] polygon = new Point[0];
        Point point;
        while (true)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                break;
            }
            Array.Resize(ref polygon, polygon.Length + 1);
            polygon[polygon.Length - 1] = new Point(x, y);
        }

        // Receive point to check
        Console.WriteLine("Enter point to check (x, y):");
        float pointX = float.Parse(Console.ReadLine());
        float pointY = float.Parse(Console.ReadLine());
        point = new Point(pointX, pointY);
        bool inside = false;
        for (int i = 0, j = polygon.Length - 1; i < polygon.Length; j = i++)
        {
            if (((polygon[i].GetY() > pointY) != (polygon[j].GetY() > pointY)) &&
                (pointX < (polygon[j].GetX() - polygon[i].GetX()) * (pointY - polygon[i].GetY()) / (polygon[j].GetY() - polygon[i].GetY()) + polygon[i].GetX()))
            {
                inside = !inside;
            }
        }

        // Output result
        if (inside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}
