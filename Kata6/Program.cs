namespace Kata6;

class Program
{
    static void Main()
    {
        
        string[] enemiesArray = {"Goblin", "Orc", "Troll", "Skeleton", "Dragon"};
        var playerInventory = new List<string> { "Sword" , "Shield" , "Potion" };
        
        

        Console.WriteLine("Enemies:");
        foreach (var listEnemiesArray in enemiesArray)
        {
            Console.WriteLine(listEnemiesArray);
        }
        
        Console.WriteLine("\nPlayer Inventory:");
        foreach (var listPlayerInventory in playerInventory)
        {
            Console.WriteLine(listPlayerInventory);
        }
        
        playerInventory.Add("Helmet");
        playerInventory.Add("Armor");
        playerInventory.Remove("Potion");
        
        
        Console.WriteLine("\nUpdated Inventory:");
        foreach (var listPlayerInventory in playerInventory)
        {
            Console.WriteLine(listPlayerInventory);
        }
        
        // var playerInventoryAmount = playerInventory.Count;
        
        Console.WriteLine($"Total Items in Inventory: {playerInventory.Count}");
        
    }
}