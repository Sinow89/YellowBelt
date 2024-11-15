namespace Kata9;

class Program
{
    static void Main()
    {
        
    }
    
}

class Player
{

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

class Enemy
{
    
    
    private string _enemyName;

    public string NameEnemy
    {
        get
        {
            return _enemyName;
        }
        set
        {
            _enemyName = NameEnemy;
        }
    }
    
}

class NPC
{
    
}