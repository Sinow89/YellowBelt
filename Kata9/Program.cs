namespace Kata9;

class Program
{
    static void Main()
    {
        var player = new Player();
        var enemy = new Enemy();
        enemy.EnemyHealth = 100;
        player.PlayerHealth = 100;
        
        player.Attack(enemy, 50);
        enemy.TakeDamage(player, 50);

        Console.WriteLine(enemy.EnemyHealth);
        Console.WriteLine(player.PlayerHealth);
            
    }
    
}

public class Player
{

    public void Attack(Enemy enemy, int damage)
    {
        enemy.EnemyHealth -= damage;
    }
    

    private string _playerName;
    
    public string Name
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