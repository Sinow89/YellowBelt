namespace MiniKata7;


class Program
{
    static void Main()
    {
        
        var player = new Player("Arin", 100, 1);
        
        var enemy = new Enemy();
        
        Console.WriteLine("Player Info:");
        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Health: {player.Health}");
        Console.WriteLine($"Level: {player.Level}");
        
        Console.WriteLine();
        
        Console.WriteLine("Enemy Info:");
        Console.WriteLine($"Type: {enemy.Type}");
        Console.WriteLine($"Health: {enemy.Health}");
        Console.WriteLine($"Damage: {enemy.Damage}");
    }
}

public class Player
{
    public string Name{ get; }
    public int Health { get; }
    public int Level{ get; }

    public Player(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }
   
}

public class Enemy
{
    public string Type;
    public int Health;
    public int Damage;
}
