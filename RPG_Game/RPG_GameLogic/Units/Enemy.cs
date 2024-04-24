using RPG_GameLogic.Interfaces;
using System.Threading.Tasks;

namespace RPG_GameLogic.Units
{
    public class Enemy : UnitBase
    {
        public Enemy(string name, string description, int maxHealth, IWeapon weapon)
            : base(name, description, maxHealth, weapon)
        {
        }
    }
}
