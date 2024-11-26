namespace Kata7;

class Program
{
    static void Main()
    {
        Player player = new Player(name:"Arin", health: 100, level: 10, experience: 50, 50);
        Enemy enemy = new Enemy(type:"Orc", health: 50);
        
        player.Attack(enemy, player);
    }
    
    public class Player
    {
        public void Attack(Enemy enemy, Player player)
        {
            Console.WriteLine($"Player {Name} hit the {enemy.Type} and deals {Damage} damage");
            enemy.TakeDamage(Damage, player);
        }

        public void GainExperience(int experience)
        {
            Experience += experience;
            Console.WriteLine($"Player {Name} gains {experience} experience points.");
        }
        
        public Player(string name, int health, int level, int experience, int damage)
        {
            Name = name;
            Health = health;
            Level = level;
            Experience = experience;
            Damage = damage;
        }
        
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Damage { get; set; }
    }

    public class Enemy
    {
        public void TakeDamage(int damage, Player player)
        {
            Health -= damage;
            Console.WriteLine($"{Type} Health: {Health}");
            
            if (Health == 0)
            {
                Console.WriteLine($"{Type} died!");
                player.GainExperience(50);
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