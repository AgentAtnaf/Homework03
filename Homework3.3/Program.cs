using System;

class CircleIntersection
{
    public static void Main()
    {
        Point center1 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
        Point center2 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
        float radius1 = float.Parse(Console.ReadLine());
        float radius2 = float.Parse(Console.ReadLine());

        float distanceOfTwoPoint = (float)Math.Sqrt((Math.Pow(center2.GetX() - center1.GetX(),2f)) + Math.Pow(center2.GetY() - center1.GetY(), 2f));

        if(distanceOfTwoPoint > radius1 + radius2 || distanceOfTwoPoint < Math.Abs(radius1 - radius2))
        {
            Console.WriteLine("No intersection points");
        }
        else if(distanceOfTwoPoint == radius1 + radius2)
        {
            Point intersectionPoint = new Point(center1.GetX() + radius1 * (center2.GetX() - center1.GetX()) / distanceOfTwoPoint,
                                                center1.GetY() + radius1 * (center2.GetY() - center1.GetY()) / distanceOfTwoPoint);
            Console.WriteLine("Intersection point: ({0}, {1})", intersectionPoint.GetX(), intersectionPoint.GetY());
        }
        else if(distanceOfTwoPoint == Math.Abs(radius1 - radius2))
        {
            Point intersectionPoint = new Point(center1.GetX() + radius1 * (center2.GetX() - center1.GetX()) / distanceOfTwoPoint,
                                                center1.GetY() + radius1 * (center2.GetY() - center1.GetY()) / distanceOfTwoPoint);
            Console.WriteLine("Intersection point: ({0}, {1})", intersectionPoint.GetX(), intersectionPoint.GetY());
        }
        else
        {
            float a = (radius1 * radius1 - radius2 * radius2 + distanceOfTwoPoint * distanceOfTwoPoint)/(2*distanceOfTwoPoint);
            float h = (float)Math.Sqrt(radius1 * radius1 - a * a);
 
            // Find P2.
            float cx2 = center1.GetX() + a * (center2.GetX() - center1.GetX()) / distanceOfTwoPoint;
            float cy2 = center1.GetY() + a * (center2.GetY() - center1.GetY()) / distanceOfTwoPoint;
 
            // Get the points P3.
            Point intersectionPoint1 = new Point((float)(cx2 + h * (center2.GetY() - center1.GetY()) / distanceOfTwoPoint),(float)(cy2 - h * (center2.GetX() - center1.GetX()) / distanceOfTwoPoint));
            Point intersectionPoint2 = new Point((float)(cx2 - h * (center2.GetY() - center1.GetY()) / distanceOfTwoPoint),(float)(cy2 + h * (center2.GetX() - center1.GetX()) / distanceOfTwoPoint));

            Console.WriteLine("Intersection points: ({2:F2}, {3:F2}) and ({0:F2}, {1:F2})", intersectionPoint1.GetX(), intersectionPoint1.GetY(), intersectionPoint2.GetX(), intersectionPoint2.GetY());
        }
    }
}
