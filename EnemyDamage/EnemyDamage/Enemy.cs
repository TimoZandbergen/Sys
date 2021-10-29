using System;
using System.Collections.Generic;
using System.Text;

namespace EnemyDamage
{
    class Enemy
    {

        public int Health { get; set; }

        public Enemy(int health)
        {
            Health = health;
        }
    }
}
