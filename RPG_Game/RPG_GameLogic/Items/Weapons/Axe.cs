using RPG_GameLogic.Interfaces;
using System;

namespace RPG_GameLogic.Items.Weapons
{
    public class Axe : IWeapon
    {
        Random rng = new Random();
        public async Task AttackAsync(IUnit attacker, IUnit target)
        {
            await Task.Delay(1000);
            

            // Generate random base damage between 10 and 25
            int baseDamage = rng.Next(13, 30); // Next(10, 26) gives a random number between 10 and 25

            // 10% chance to do half damage
            double chance = rng.NextDouble();
            int damage = chance < 0.1 ? baseDamage / 2 : baseDamage;

            Console.WriteLine($"{attacker.Name} swings the axe at {target.Name} for {damage} damage.");
            target.TakeDamage(damage);
            if (target.CurrentHealth > 0)
            {
                Console.WriteLine($"{target.Name} has {target.CurrentHealth} health remaining.\n");
            }

        }
    }
}
