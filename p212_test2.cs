public class ColorProgram
{
    public void Run()
    {
        Color White = new Color(255, 255, 255);
        Color Black = new Color(0, 0, 0);
        Color Red = new Color(255, 0, 0);
        Color Orange = new Color(255, 165, 0);
        Color Yellow = new Color(255, 255, 0);
        Color Green = new Color(0, 128, 0);
        Color Blue = new Color(0, 0, 255);
        Color Purple = new Color(128, 0, 128);

        Color RandomColor = Color.CreateColor(0, 2, 3);
        Console.WriteLine($"{White.red}, {White.green}, {White.blue}");
        Console.WriteLine($"{RandomColor.red}, {RandomColor.green}, {RandomColor.blue}");

    }
}

public class Color
{
    public int red;
    public int green;
    public int blue;

    public Color(int r, int g, int b)
    {
        red = r;
        green = g;
        blue = b;
    }
    public static Color CreateColor(int r, int g, int b)
    {
        return new Color(r, g, b);
    }
}