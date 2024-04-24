using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Interfaces
{
    public interface IUnit
    {
        string Name { get; }
        string Description { get; }
        int MaxHealth { get; }
        int CurrentHealth { get; set; }
        Task AttackAsync(IUnit target);
        void Die();
        void Move();
        void TakeDamage(int damage);
    }
}
