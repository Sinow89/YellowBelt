namespace Kata7;

class Program
{
    static void Main()
    {

        Player player = new Player(name:"Arin", health: 100, level: 10, experience: 50 );
        Enemy enemy = new Enemy(type:"Orc", health: 50);
        

        player.Attack(20, enemy.Type);
        player.GainExperience(50, enemy.Health);
        enemy.TakeDamage(20);
        Console.WriteLine($"Player {player.Name} gains {player.Experience} experience points.");



    }


    public class Player
    {

        public void Attack(int damage, string type)
        {
            Health -= damage;
            Console.WriteLine($"Player {Name} hit the {type} and deals {damage} damage");
        }

        public void GainExperience(int Experience, int health)
        {

        }


        public Player(string name, int health, int level, int experience)
        {
            Name = name;
            Health = health;
            Level = level;
            Experience = experience;
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
            Console.WriteLine($"{Type} hit {damage} damage. Health: {Health}");
            
            if (Health == 0)
            {
                
            }
        }

        public string Type { get; set; }
        public int Health { get; set; }
        
        public Enemy(string type, int health)
        {
            Type = type;
            Health = health;
        }

    }
}