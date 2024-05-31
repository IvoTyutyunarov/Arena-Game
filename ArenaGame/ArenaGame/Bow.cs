using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Bow : Weapon
    {
        public Bow() : base("Bow", 15, "Piercing Arrow")
        {
        }

        public override int GetAttackBonus()
        {
            return base.GetAttackBonus() + (ThrowDice(15) ? 20 : 0);
        }

        private bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }
    }
}
