namespace Kata10;

class Program
{
    static void Main()
    {
        var player = new Player();
        var enemy = new Enemy();
        var npc = new NPC();
        var merchant = new Merchant();

        player.Name= "Arin";
        player.PlayerHealth = 100;
        enemy.Health = 100;
        enemy.Name ="Orc";
        npc.NPCName = "NPC";
        merchant.MerchantName = "Merchant";
        
        player.Attack(enemy, 20);
        enemy.TakeDamage(20);
        npc.Speak("Welcome to out village");
        merchant.Speak("Ready to trade!");

        
    }
    
}


public interface IAttackable
{
    int Health { get; set; }
    string Name { get; }
    void TakeDamage(int damage);
}

public interface IDialogue
{
    string Name { get; }
    void Speak(string dialogue);
}

public class Player
{
    public void Attack(IAttackable target, int damage)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with {damage} damage");
    }
    

    private string name;
    
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
    
    private int _playerHealth;

    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }
        set
        {
            _playerHealth = value;
        }
    }

    private int _playerLevel;

    public int PlayerLevel
    {
        get
        {
            return _playerLevel;
        }
        set
        {
            _playerLevel = value;
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
    private string _npcName;
    private string _npcDialogue;
    public string Name => NPCName;

    public void Speak(string dialogue)
    {
        Console.WriteLine($"{Name} says: {dialogue}");
    }

    public string NPCName
    {
        get
        {
            return _npcName;
        }
        set
        {
            _npcName = value;
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
    private string _merchantName;
    private string _merchantInventory;
    public string Name => MerchantName;
    
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

    public string MerchantName
    {
        get
        {
            return _merchantName;
        }
        set
        {
            _merchantName = value;
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