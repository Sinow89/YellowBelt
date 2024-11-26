namespace Kata10;

class Program
{
    static void Main()
    {
        var player = new Player("Arin");
        var enemy = new Enemy();
        var npc = new NPC();
        var merchant = new Merchant();
        
        player.Health = 100;
        enemy.Health = 100;
        enemy.Name ="Orc";
        npc.Name = "NPC";
        merchant.Name = "Merchant";
        
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

    public Player(string name)
    {
        Name = name;
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
    
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    
    private string name;
    private int health;
    private int _enemyDamage;
    
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

    public int EnemyDamage
    {

        get
        {
            return _enemyDamage;
        }
        set
        {
            _enemyDamage = value;
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
    private string _npcDialogue;
    

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

    public string NpcDialogue
    {
        get
        {
            return _npcDialogue;
        }
        set
        {
            _npcDialogue = value;
        }
    }
    
}

class Merchant : IDialogue
{
    private string name;
    private string _merchantInventory;
    
    
    public void Speak(string dialogue)
    {
        Console.WriteLine($"{Name} says: {dialogue}");
    }

    
    List<string> MerchantInventoryList = new List<string> { "Sword", "Shield", "Potion" };

    public void Trade() 
    {
        {
            Console.WriteLine($"Merchant's inventory: {MerchantInventoryList[0]}, {MerchantInventoryList[1]}, {MerchantInventoryList[2]}");
        }
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

    public string MerchantInventory
    {
        get
        {
            return _merchantInventory;
        }
        set
        {
            _merchantInventory = value;
        }
    }
}