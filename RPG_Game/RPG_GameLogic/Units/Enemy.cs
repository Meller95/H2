using RPG_GameLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GameLogic.Units
{
    public class Enemy : IUnit
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; set; }
        public IWeapon Weapon { get; private set; }

        // Constructor that accepts a weapon
        public Enemy(IWeapon weapon)
        {
            Name = "Goblin";
            Description = "A sneaky goblin.";
            MaxHealth = 150;
            CurrentHealth = 150;
            Weapon = weapon ?? throw new ArgumentNullException(nameof(weapon), "Weapon cannot be null.");
        }

        public async Task AttackAsync(IUnit target)
        {
            await Weapon.AttackAsync(this, target);
            // Additional asynchronous logic can be added here
        }

        public void Die()
        {
            Console.WriteLine($"{Name} has been defeated.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} scuttles closer.");
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            
            if (CurrentHealth <= 0) Die();
        }
    }
}
