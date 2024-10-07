using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSurvival_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("nonihunny49", "Noni", 100, 50);

            Zombie fastzombie = new Zombie("FastZombie", 50, 10);
            Zombie strongzombie = new Zombie("StrongZombie", 50, 40);
            Zombie explodezombie = new Zombie("ExplodeZombie", 50, 15);

        }
    }
}
