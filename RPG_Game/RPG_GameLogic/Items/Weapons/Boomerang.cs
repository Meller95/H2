using RPG_GameLogic.Interfaces;
using System;
using System.Threading.Tasks;

namespace RPG_GameLogic.Items.Weapons
{
    public class Boomerang : IWeapon
    {
        private Random rng = new Random();

        public async Task AttackAsync(IUnit attacker, IUnit target)
        {
            await Task.Delay(1000); 

            
            int baseDamage = rng.Next(5, 24);

            
            Console.WriteLine($"{attacker.Name} throws the boomerang at {target.Name} for {baseDamage} damage.");
            target.TakeDamage(baseDamage);

            
            double returnChance = rng.NextDouble();

            if (returnChance < 0.5) // 50% chance to hit again
            {
                int returnDamage = (baseDamage / 2) + 3;
                Console.WriteLine($"The boomerang returns, hitting {target.Name} again for an additional {returnDamage} damage!");
                target.TakeDamage(returnDamage);
            }

            if (target.CurrentHealth > 0)
            {
                Console.WriteLine($"{target.Name} has {target.CurrentHealth} health remaining.\n");
            }
        }
    }
}
