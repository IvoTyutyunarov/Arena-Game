using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int AttackBonus { get; private set; }
        public string SpecialAbility { get; private set; }

        public Weapon(string name, int attackBonus, string specialAbility = null)
        {
            Name = name;
            AttackBonus = attackBonus;
            SpecialAbility = specialAbility;
        }

        public virtual int GetAttackBonus()
        {
            return AttackBonus;
        }
    }
}
