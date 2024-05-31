using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Sword : Weapon
    {
        public Sword() : base("Sword", 20, "Extra Slash")
        {
        }

        public override int GetAttackBonus()
        {
            return base.GetAttackBonus() + (ThrowDice(10) ? 30 : 0);
        }

        private bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }
    }
}
