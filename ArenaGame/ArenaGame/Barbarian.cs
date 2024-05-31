using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Barbarian : Hero
    {
        private const int RageBonusChance = 25;

        public Barbarian(string name, Weapon weapon) : base(name, weapon)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(RageBonusChance))
            {
                attack += 40; // Rage bonus
            }
            return attack;
        }

        private bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }
    }
}
