namespace MiniKata6;

class Program
{
    static void Main()
    {
        string[] enemies = {"Goblin", "Orc", "Troll"};
        var playerInventory = new List<string>();
        playerInventory.Add("Sword","Shield");
        playerInventory.Add("Shield");
        playerInventory.Add("Potion");
        
        Console.WriteLine("Enemies");
        foreach (var listEnemies in enemies) 
        {
            Console.WriteLine(listEnemies);
        }
Console.WriteLine();
Console.WriteLine("Player Inventory");
        foreach (var listPlayerInventory in playerInventory)
        {
            Console.WriteLine(listPlayerInventory);
        }

        playerInventory.Add("Helmet");
        Console.WriteLine();
        Console.WriteLine("Updated Inventory");
        
        foreach (var listPlayerInventory in playerInventory)
        {
            Console.WriteLine(listPlayerInventory);
        }
        
    }
}