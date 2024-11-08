namespace MiniKata5;

class Program
{

    public void Attack(int damage)
    {
        Console.WriteLine(damage);
    }
    
    
    static void Main()
    {
        Program program = new Program();
        program.Attack(10);
    }
}