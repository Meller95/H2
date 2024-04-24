using RPG_GameLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_GameLogic.Interfaces.IUnit;

namespace RPG_GameLogic.Units
{
    public class Player : IUnit
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; set; }
        public RPG_GameLogic.Interfaces.IWeapon Weapon { get; private set; }

        public Player(RPG_GameLogic.Interfaces.IWeapon weapon)
        {
            Name = "Hero";
            Description = "The brave protagonist of our story.";
            MaxHealth = 150;
            CurrentHealth = 150;
            Weapon = weapon ?? throw new ArgumentNullException(nameof(weapon), "Weapon cannot be null.");
        }

        public async Task AttackAsync(IUnit target)
        {
            await Weapon.AttackAsync(this, target);
        }

        public void Die()
        {
            Console.WriteLine($"{Name} has died in battle.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves strategically.");
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            
            if (CurrentHealth <= 0) Die();
        }
    }
}
