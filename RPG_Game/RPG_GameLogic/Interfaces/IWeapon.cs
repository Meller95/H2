using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Interfaces
{
    public interface IWeapon
    {
        Task AttackAsync(IUnit attacker, IUnit target);
    }
}
