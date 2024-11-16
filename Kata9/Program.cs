namespace Kata9;

class Program
{
    static void Main()
    {
        var player = new Player();
        var enemy = new Enemy();
        var npc = new NPC();
        var merchant = new Merchant();

        player.PlayerName= "Arin";
        player.PlayerHealth = 100;
        enemy.EnemyHealth = 100;
        enemy.EnemyName ="Orc";
        npc.NpcName = "NPC";
        
        player.Attack(enemy, 20);
        enemy.TakeDamage(player, 20);
        npc.Speaks();
        merchant.Trade();

        
    }
    
}

public class Player
{

    public void Attack(Enemy enemy, int damage)
    {
        enemy.EnemyHealth -= damage;
        Console.WriteLine($"{_playerName} attacks {enemy.EnemyName} with {damage} damage");
    }
    

    private string _playerName;
    
    public string PlayerName
    {
        get
        {
            return _playerName;
        }
        set
        {
            _playerName = value;
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

public class Enemy
{
    public void TakeDamage(Player player, int damage)
    {
        player.PlayerHealth -= damage;
        Console.WriteLine($"{_enemyName} attacks {player.PlayerName} with {damage} damage. Remaining health: {player.PlayerHealth}");
    }
    
    private string _enemyName;
    private int _enemyHealth;
    private int _enemyDamage;

    
    public string EnemyName
    {
        get
        {
            return _enemyName;
        }
        set
        {
            _enemyName = value;
        }
    }

    public int EnemyHealth
    {
        get
        {
            return _enemyHealth;
        }
        set
        {
            _enemyHealth = value;
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
    
    
    
}

class NPC
{
    private string _npcName;
    private string _npcDialogue;

    public void Speaks()
    {
        Console.WriteLine($"{_npcName} say: Welcome to our village!");
    }

    public string NpcName
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

class Merchant
{
    private string _merchantName;
    private string _merchantInventory;

    
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