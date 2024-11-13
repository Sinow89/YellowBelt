namespace MiniKata7;


class Program
{
    static void Main()
    {
        
        var player = new Player("Arin", 100, 1);
        
        var enemy = new Enemy("Goblin", 50, 10);
        
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

public class Player(string name, int health, int level)
{
    public string Name{ get; } = name;
    public int Health { get; } = health;
    public int Level{ get; } = level;
}

public class Enemy
{
    
    public string Type { get; }
    public int Health { get; }
    public int Damage { get; }

    
    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }
}
