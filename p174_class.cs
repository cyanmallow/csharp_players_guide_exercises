using System;

class Program {
    Dictionary<int, string> typeDir = new Dictionary<int, string>();
    // same as var typeDir = new .......
    Dictionary<int, string> ingredientDir = new Dictionary<int, string>();
    Dictionary<int, string> seasoningDir = new Dictionary<int, string>();

    static void Main(){
        Program p = new Program();
        p.Run();
    }

    void Run(){
        typeDir.Add(1, "Soup");
        typeDir.Add(2, "Stew");
        typeDir.Add(3, "Gumbo");

        ingredientDir.Add(1, "Mushroom");
        ingredientDir.Add(2, "Chicken");
        ingredientDir.Add(3, "Carrot");
        ingredientDir.Add(4, "Potato");

        seasoningDir.Add(1, "Spicy");
        seasoningDir.Add(2, "Salty");
        seasoningDir.Add(3, "Sweet");

        Console.WriteLine($"Welcome to our restaurant! What will you have today?");
        Console.WriteLine($"Soup? Stew? Or gumbo? (1/2/3) ");
        int type = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your main ingredient? We have mushrooms, chicken, carrots and potatoes! (1/2/3/4) ");
        int ingredient = int.Parse(Console.ReadLine());
        Console.WriteLine($"Do you want your food to be spicy, salty or sweet? (1/2/3) ");
        int seasoning = int.Parse(Console.ReadLine());
 
        (string s, string i, string t) meal = (seasoningDir[seasoning], ingredientDir[ingredient], typeDir[type]);
        
        Console.WriteLine($"Heres your {meal.s} {meal.i} {meal.t}.");
    }
}