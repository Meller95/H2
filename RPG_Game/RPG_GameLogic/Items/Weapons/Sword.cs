using RPG_GameLogic.Interfaces;
using System;

namespace RPG_GameLogic.Items.Weapons
{
    public class Sword : IWeapon
    {
        private Random rng = new Random();

        public async Task AttackAsync(IUnit attacker, IUnit target)
        {
            await Task.Delay(1000);
            // Generate random base damage between 10 and 25
            int baseDamage = rng.Next(10, 26); // Next(10, 26) gives a random number between 10 and 25

            // 30% chance to double the damage
            double chance = rng.NextDouble();
            int damage = chance < 0.3 ? baseDamage * 2 : baseDamage;

            Console.WriteLine($"{attacker.Name} swings the sword at {target.Name} for {damage} damage.");
            
            target.TakeDamage(damage);
            if (target.CurrentHealth > 0)
            {
                Console.WriteLine($"{target.Name} has {target.CurrentHealth} health remaining.\n");
            }
        }
    }
}
