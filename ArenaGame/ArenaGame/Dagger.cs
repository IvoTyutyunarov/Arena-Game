using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Dagger : Weapon
    {
        public Dagger() : base("Dagger", 10, "Quick Stab")
        {
        }

        public override int GetAttackBonus()
        {
            return base.GetAttackBonus() + (ThrowDice(20) ? 15 : 0);
        }

        private bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }
    }
}
