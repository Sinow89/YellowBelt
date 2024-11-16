namespace Kata8;

class Program
{
    static void Main()
    {
        
        var player = new Player();
        player.GainExperience(50);
        player.GainExperience(60);
        player.LevelUp();
        
    }
}


class Player
{

    public void GainExperience(int experience)
    {
        Experience += experience;
        Console.WriteLine($"Gained experience: {experience}");
    }

    public void LevelUp()
    {
        while (Experience >= 100)
        {
            Level++;
            Experience -= 100;
            Console.WriteLine("Congratulations! You level up to " + Level);
        }
        
    }
    
    private int _health = 100;
    public int _level = 1;
    public int _experience;

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