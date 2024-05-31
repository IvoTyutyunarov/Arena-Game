using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int FireballDamageChance = 20;

        public Mage(string name, Weapon weapon) : base(name, weapon)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(FireballDamageChance))
            {
                attack += 50;
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
