using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSurvival_1
{
    internal class Character
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public bool IsAlive => Health > 0;

        public Character(string name, int health, int attackpower)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int damageToHealth)
        {
            Health -= damageToHealth;
            if (Health < 0)
            {
                //
            }
        }

    }
}
