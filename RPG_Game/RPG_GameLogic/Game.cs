using RPG_GameLogic.Factories;
using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Units;

namespace RPG_GameLogic.GameManagement
{
    public class Game
    {
        private Player player;
        private Enemy enemy;
        private readonly SemaphoreSlim turnSemaphore = new SemaphoreSlim(1, 1);
        private Random rng = new Random();

        public Game(Player player)
        {
            this.player = player;
            this.enemy = CreateNewEnemy();
        }

        private Enemy CreateNewEnemy()
        {
            int health = rng.Next(40, 60);
            IWeapon weapon = WeaponFactory.CreateWeapon();
            Enemy newEnemy = new Enemy("Goblin", "Just another sneaky goblin", health, weapon);
            Console.WriteLine($"A new goblin appears! It looks sneaky.\n");
            return newEnemy;
        }

        public async Task StartGameAsync()
        {
            Console.WriteLine();

            while (player.CurrentHealth > 0) 
            {
                if (enemy.CurrentHealth <= 0)
                {
                   
                    enemy = CreateNewEnemy(); // Create a new enemy when the current one is defeated
                }

                await PerformTurn(player, enemy);
                if (player.CurrentHealth <= 0) break; 

                if (enemy.CurrentHealth > 0)
                {
                    await PerformTurn(enemy, player);
                }
            }

            EndGame();
        }

        private async Task PerformTurn(IUnit attacker, IUnit defender)
        {
            await turnSemaphore.WaitAsync();
            try
            {
                if (defender.CurrentHealth > 0)
                {
                    await attacker.AttackAsync(defender);
                    
                }
            }
            finally
            {
                turnSemaphore.Release();
            }
        }

        private void EndGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game over!");
            Console.WriteLine($"{player.Name} has been defeated!\n");
            Console.ResetColor();
        }
    }
}
