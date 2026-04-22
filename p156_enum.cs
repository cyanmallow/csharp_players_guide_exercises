using System;

public class Enum_Program
{
    public ChestState currentState = ChestState.locked;

    //public static void Main()
    //{
    //    Enum_Program p = new Enum_Program();
    //    p.Run();
    //}
    public void Run()
    {
        while (true)
        {
            Console.WriteLine($"The chest is {currentState}. What do you want to do? ");
            string action = Console.ReadLine()?.ToLower() ?? "";

            if (action == "unlock" && currentState == ChestState.locked)
                currentState = ChestState.closed;

            else if (action == "open" && currentState == ChestState.closed)
                currentState = ChestState.open;

            else if (action == "close" && currentState == ChestState.open)
                currentState = ChestState.closed;

            else
            {
                Console.WriteLine("Invalid Action.");
            }
        }
    }

    public enum ChestState { open, closed, locked }
}

