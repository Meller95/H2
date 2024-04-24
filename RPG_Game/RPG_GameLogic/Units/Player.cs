using RPG_GameLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_GameLogic.Interfaces.IUnit;

namespace RPG_GameLogic.Units
{
    public class Player : UnitBase
    {
        public Player(string name, string description, int maxHealth, IWeapon weapon)
            : base(name, description, maxHealth, weapon)
        {
        }
    }
}
