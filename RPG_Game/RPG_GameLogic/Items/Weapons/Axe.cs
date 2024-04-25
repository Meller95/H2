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
            

            
            int baseDamage = rng.Next(13, 30);

            
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
