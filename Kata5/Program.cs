
namespace Kata5;

internal abstract class Program
{

    private static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"Attacked {enemyName} and dealt {damage} damage!");
    }
    
    private static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine($"Player {playerName} healed {healAmount} health points!");
    }
    
    
    static void Main()
    {
        AttackEnemy(enemyName:"Goblin",damage:20);
        HealPlayer(playerName:"Arin", healAmount:15);
    }
}