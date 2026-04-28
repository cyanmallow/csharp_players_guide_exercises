public class test1Program
{
    public static void Run()
    {
        Point pointA = new Point(2, 3);
        Point pointB = new Point(-4, 0);

        Console.WriteLine($"({pointA.x}, {pointA.y})");
        Console.WriteLine($"({pointB.x}, {pointB.y})");
    }
}

public class Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public static Point CreatePointAt00()
    {
        return new Point(0, 0);
    }
}
