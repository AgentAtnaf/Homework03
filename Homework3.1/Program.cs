using System;

class Q4
{
    public static void Main()
    {
        Point p1 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
        Point p2 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
        Point p3 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));

        float a = p2.GetX() - p1.GetX();
        float b = p2.GetY() - p1.GetY();
        float c = p3.GetX() - p1.GetX();
        float d = p3.GetY() - p1.GetY();

        float e = a * (p1.GetX() + p2.GetX()) + b * (p1.GetY() + p2.GetY());
        float f = c * (p1.GetX() + p3.GetX()) + d * (p1.GetY() + p3.GetY());
        float g = 2 * (a * (p3.GetY() - p2.GetY()) - b * (p3.GetX() - p2.GetX()));

        if (g == 0)
        {
            Console.WriteLine("The three points are collinear and do not form a circle.");
        }
        else
        {
            float centerX = (d * e - b * f) / g;
            float centerY = (a * f - c * e) / g;
            float radius = (float)Math.Sqrt(Math.Pow(centerX - p1.GetX(), 2f) + Math.Pow(centerY - p1.GetY(), 2f));

            Console.WriteLine("Center: ({0:F5}, {1:F5})", centerX, centerY);
            Console.WriteLine("Radius: {0:F5}", radius);
        }
    }
}
