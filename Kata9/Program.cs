namespace Kata9;

class Program
{
    static void Main()
    {
        
    }
    
}

class Player
{

    private string _name;
    
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    
    private int _health;

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    private int _level;

    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = value;
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
            return _enemyName
        }
        set
        {
            _enemyName = NameEnemy
        }
    }
    
}

class NPC
{
    
}