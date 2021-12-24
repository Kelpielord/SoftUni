

string[] firstCircleInput = Console.ReadLine().Split();
string[] secondCircleInput = Console.ReadLine().Split();

Circle firstCircle = new Circle();

firstCircle.X = int.Parse(firstCircleInput[0]);
firstCircle.Y = int.Parse(firstCircleInput[1]);
firstCircle.Radius = int.Parse(firstCircleInput[2]);

Circle secondCircle = new Circle();

secondCircle.X = int.Parse(secondCircleInput[0]);
secondCircle.Y = int.Parse(secondCircleInput[1]);
secondCircle.Radius = int.Parse(secondCircleInput[2]);

bool circleIntersect = Circle.Intersect(firstCircle, secondCircle);
if (circleIntersect)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


public class Circle
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Radius { get; set; }

    public static bool Intersect(Circle firstCircle, Circle secondCircle)
    {
        double deltaX = Math.Abs(firstCircle.X - secondCircle.X);
        double deltaY = Math.Abs(firstCircle.Y - secondCircle.Y);
        double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        double sumRadius = firstCircle.Radius + secondCircle.Radius;

        if (sumRadius >= distance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

