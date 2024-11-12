namespace MiniKata7;


class Program
{
    static void Main()
    {
        
        Player player = new Player();
        player.Name = "Arin";
        player.Health = 100;
        player.Level = 1;


    }
}

public class Player
{
    public string Name;
    public int Health;
    public int Level;
}

public class Enemy
{
    public string Type;
    public int Health;
    public int Damage;
}
