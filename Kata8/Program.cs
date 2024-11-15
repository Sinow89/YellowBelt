namespace Kata8;

class Program
{
    static void Main()
    {
        
        var player = new Player();
        player.LevelUp();
        
    }
}


class Player
{


    public void LevelUp()
    {
        
        if(_experience >= 100)
        ++_level;
        _experience = 0;
    }
    
    private int _health = 100;
    public int _level = 1;
    public int _experience = 50;

    public int Health
    {
        get
        {
            return _health;
        }
    }
    
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
    
    public int Experience
    {
        get
        {
            return _experience;
        }
        set
        {
            _experience = value;
        }
    }
    
}