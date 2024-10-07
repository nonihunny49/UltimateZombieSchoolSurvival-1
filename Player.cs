using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSurvival_1
{
    internal class Player : Character
    {
        public string Username { get; set; }

        public Player(string username, string name, int health, int attackpower) : base(name, health, attackpower)
        {
            Username = username;
        }

        public void PlayerHeal(int amount)
        {
            Health += amount;
        }

    }
}
