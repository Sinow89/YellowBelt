namespace Kata10;

class Program
{
    static void Main()
    {
        var player = new Player("Arin", 100);
        var enemy = new Enemy("Orc", 100);
        var npc = new NPC("NPC");
        var merchant = new Merchant("Merchant");
        
        player.Attack(enemy, 20);
        enemy.TakeDamage(20);
        npc.Speak("Welcome to out village");
        merchant.Speak("Ready to trade!");
    }
}

public interface IAttackable
{
    int Health { get; set; }
    void TakeDamage(int damage);
}

public interface IDialogue
{
    string Name { get; }
    void Speak(string dialogue);
}

public class Player
{
    public void Attack(Enemy target, int damage)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with {damage} damage");
    }
    
    public string Name { get; }

    public Player(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    private int level;
    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
        }
    }
}

public class Enemy : IAttackable
{
    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    
    private string name;
    private int health;
    private int damage;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}");
    }
}

class NPC : IDialogue
{
    private string name;
    private string dialogue;

    public NPC(string name)
    {
        Name = name;
    }

    public void Speak(string dialogue)
    {
        Console.WriteLine($"{Name} says: {dialogue}");
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public string Dialogue
    {
        get
        {
            return dialogue;
        }
        set
        {
            dialogue = value;
        }
    }
}

class Merchant : IDialogue
{
    private string name;
    private string inventory;

    public Merchant(string name)
    {
        Name = name;
    }
    
    public void Speak(string dialogue)
    {
        Console.WriteLine($"{Name} says: {dialogue}");
    }
    
    List<string> InventoryList = new(){ "Sword", "Shield", "Potion" };

    public void Trade() 
    {
        Console.WriteLine($"Merchant's inventory: {InventoryList[0]}, {InventoryList[1]}, {InventoryList[2]}");
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public string Inventory
    {
        get
        {
            return inventory;
        }
        set
        {
            inventory = value;
        }
    }
}