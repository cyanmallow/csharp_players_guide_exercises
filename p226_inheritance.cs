public class Inheritance
{
    public static void Run()
    {
        Pack pack = new Pack(0, 0, 0);
        while (true)
        {
            Console.WriteLine("What do you want to do? 1. Check your bag. / 2. Add an item");
            int.TryParse(Console.ReadLine(), out int choiceA);

            if (choiceA == 1)
            {
                pack.PrintCurrent();
            }
            else if (choiceA == 2)
            {
                Console.WriteLine("What item do you want to add? 1. Bow / 2. Arrow / 3. Water / 4. Food / 5. Sword / 6. Rope");
                int.TryParse(Console.ReadLine(), out int choiceB);
                if (choiceB == 1)
                    pack.Add(new Bow());
                else if (choiceB == 2)
                    pack.Add(new Arrow());
                else if (choiceB == 3)
                    pack.Add(new Water());
                else if (choiceB == 4)
                    pack.Add(new Food());
                else if (choiceB == 5)
                    pack.Add(new Sword());
                else if (choiceB == 6)
                    pack.Add(new Rope());
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");

            }
        }
    }
    public class Pack
    {
        public float currentTotalItem;
        public float currentTotalWeight;
        public float currentTotalVolumn;
        public float TotalItemLimit { 
            get => _TotalItemLimit;
            set
            {
                _TotalItemLimit = value;
            } }
        private float _TotalItemLimit = 5;
        public float WeightLimit { get; }
        public float VolumnLimit { get; }

        public Pack(float i, float w, float v)
        {
            TotalItemLimit = i;
            WeightLimit = w;
            VolumnLimit = v;
        }

        public bool Add(InventoryItem item)
        {
            if (TotalItemLimit + item.ItemWeight < currentTotalItem)
            {
                return false;
            }
            else
            {
                currentTotalItem += 1;
                currentTotalWeight += item.ItemWeight;
                currentTotalVolumn += item.ItemVolumn;
                return true;
            }
        }

        public void PrintCurrent()
        {
            Console.WriteLine($"Current total item: {currentTotalItem}");
            Console.WriteLine($"Current total weight: {currentTotalWeight}");
            Console.WriteLine($"Current total volumn: {currentTotalVolumn}");
        }
    }

    public  class InventoryItem(float w, float v)
    {
        public float ItemWeight = w;
        public float ItemVolumn = v;
    }

    public class Rope: InventoryItem
    {
        public Rope() : base(0.1f, 0.05f) { }
    }
    public class Bow: InventoryItem
    {
        public Bow() : base(1, 4) { }
    }
    public class Arrow: InventoryItem
    {
        public Arrow() : base(0.1f, 0.05f) { }
    }
    public class Water: InventoryItem
    {
        public Water() : base(2, 3) { }
    }
    public class Food: InventoryItem
    {
        public Food() : base(1, 0.5f) { }
    }
    public class Sword: InventoryItem
    {
        public Sword() : base(5, 3) { }
    }
}

