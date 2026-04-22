using System;
using System.Collections.Generic;

public class ClassProgram
{
    public static void Run(){
        var arrowheadDir = new Dictionary<int, float>{
            {1, 10},
            {2, 3},
            {3, 5}
        };

        var fletchingDir = new Dictionary<int, float>{
            {1, 10},
            {2, 5},
            {3, 3}
        };

        Console.WriteLine($"Pick an arrow head! 1. Steel/ 2. Wood/ 3. Obsidian ");
        int arrowheadOfChoice = int.Parse(Console.ReadLine());
        Console.WriteLine($"Shaft length? Between 60 and 100cm only. ");
        int lengthOfChoice = int.Parse(Console.ReadLine());
        Console.WriteLine($"What about the fletching? 1. Plastic/ 2. Turkey feathers/ 3. Goose feathers ");
        int fletchingOfChoice = int.Parse(Console.ReadLine());

        float price = (float)(arrowheadDir[arrowheadOfChoice] + fletchingDir[fletchingOfChoice] + 0.05 * lengthOfChoice);

        Console.WriteLine($"Now pay up ${price}"); 
    }
}

//public class Arrow(Arrow.arrowhead a, float s, Arrow.fletching f)
//{
//    private float _shaft;
//    public enum arrowhead {steel, wood, obsidian}
//    private float shaft = s;
//    public enum fletching {plastic, turkeyfeathers, goosefeathers}

//    public float getShaft() => _shaft;

//    private arrowhead Head = a;
//    private fletching Fletch = f;
//}
