using System;

namespace EnemyDamage
{
    public class Program
    {
        static void Main(string[] args)
        {

            Enemy enemy = new Enemy(100);
            while(enemy.Health > 0)
            {
                enemy.Health -= 10;
                Console.WriteLine(enemy.Health);
            }
        }
        
    }

}
