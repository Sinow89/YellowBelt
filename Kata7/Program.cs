namespace Kata7;

class Program
{
    static void Main()
    {
        
        Player player = new Player();
        Enemy enemy = new Enemy();
        
        player.Attack(10);

        
}


public class Player
{

    public void Attack(int damage)
    {
        Console.WriteLine($"You hit {damage} damage");
    }
    
    public void GainExperience(int Experience)
    {
        Console.WriteLine($"Player {Name} gains {Experience} experience points.");
    }
    

    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    
    
}

public class Enemy
{

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    
    public string Type { get; set; }
    public int Health { get; set; }
    
}