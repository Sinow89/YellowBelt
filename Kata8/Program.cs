namespace Kata8;

class Program
{
    static void Main()
    {
        
    }
}


class Player
{
    private int _health = 100;

    public int Health
    {
        get
        {
            return _health;
        }
    }

    public int _level = 1;

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


    public int _experience = 50;

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