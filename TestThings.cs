//using System;

//public class TestThings
//{
//    public static void Run()
//    {
//        var arrowheadDir = new Dictionary<int, float>{
//            {1, 10},
//            {2, 3},
//            {3, 5}
//        };

//        var fletchingDir = new Dictionary<int, float>{
//            {1, 10},
//            {2, 5},
//            {3, 3}
//        };

//        Console.WriteLine($"Pick an arrow head! 1. Steel/ 2. Wood/ 3. Obsidian ");
//        int arrowheadOfChoice = int.Parse(Console.ReadLine());
//        Console.WriteLine($"Shaft length? Between 60 and 100cm only. ");
//        //int lengthOfChoice = int.Parse(Console.ReadLine());
//        try {
//            if (lengthOfChoice < 60 || lengthOfChoice > 100)
//            {
//                //throw new Exception("Invalid shaft length. Please choose a length between 60 and 100 cm.");
//                Console.WriteLine($"Shaft length? Between 60 and 100cm only. ");

//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//            return; // Exit the method if the input is invalid
//        }
//        int lengthOfChoice = int.Parse(Console.ReadLine());


//        Console.WriteLine($"What about the fletching? 1. Plastic/ 2. Turkey feathers/ 3. Goose feathers ");
//        int fletchingOfChoice = int.Parse(Console.ReadLine());

//        float price = (float)(arrowheadDir[arrowheadOfChoice] + fletchingDir[fletchingOfChoice] + 0.05 * lengthOfChoice);

//        Console.WriteLine($"Now pay up ${price}");
//    }
//}

