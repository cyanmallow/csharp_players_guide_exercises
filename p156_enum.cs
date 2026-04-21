// using System;

// class Enum_Program {
//     public ChestState currentState = ChestState.locked;

//     static void Main(){
//         Program p = new Program();
//         p.Run();
//     }
//     void Run(){
//         while (true){
//             Console.WriteLine($"The chest is {currentState}. What do you want to do? ");
//             string action = Console.ReadLine()?.ToLower() ?? "";
        
//             if (action == "unlock" && currentState == ChestState.locked)
//                 currentState = ChestState.closed;

//             else if (action == "open" && currentState == ChestState.closed)
//                 currentState = ChestState.open;

//             else if (action == "close" && currentState == ChestState.open)
//                 currentState = ChestState.closed;        
        
//             else {
//                 Console.WriteLine("Invalid Action.");
//             }
//         }
//     }

//     public enum ChestState {open, closed, locked}
// }

