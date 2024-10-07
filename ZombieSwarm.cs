using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSurvival_1
{
    internal class ZombieSwarm
    {
        private List<Zombie> zombies;

        public ZombieSwarm()
        {
            zombies = new List<Zombie>();
        }

        public void SwarmAttack(Player player) //parameters to add
        {
            Console.WriteLine("The zombie swarm is attacking!");
            foreach (Zombie zombie in zombies)
            {
                if (zombie.IsAlive)
                {
                 
                }

            }
        }
        public void AddZombie(Zombie zombie)
        {
            zombies.Add(zombie);

        }

        public void Display()
        {
            foreach (Zombie zombie in zombies)
            {
                Console.WriteLine(zombie.Name);
            }
        }

    }
}
