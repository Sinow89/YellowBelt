namespace MiniKata5;

internal abstract class Program
{

    private static void Attack(int damage)
    {
        Console.WriteLine($"Player dealt {damage} damage!");
    }
    
    private static void Heal(int healAmount)
    {
        Console.WriteLine($"Player healed {healAmount} health points!");
    }
    
    
    static void Main()
    {
        Attack(15);
        Heal(10);
    }
}