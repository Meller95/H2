using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Units;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_GameLogic.GameManagement
{
    public class Game
    {
        private Player player;
        private Enemy enemy;
        private volatile bool gameOver = false;
        private readonly SemaphoreSlim turnSemaphore = new SemaphoreSlim(1, 1);

        public Game(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }

        public async Task StartGameAsync()
        {
            
            InitializeGame();

            var playerTask = PlayerCombatLoop();
            var enemyTask = EnemyCombatLoop();

            await Task.WhenAll(playerTask, enemyTask);

            EndGame();
        }

        private async Task PlayerCombatLoop()
        {
            while (!gameOver && player.CurrentHealth > 0)
            {
                await PerformTurn(player, enemy);
                if (gameOver) break; // Check if the game should end before the delay
                await Task.Delay(1000); // Time between turns
            }
        }

        private async Task EnemyCombatLoop()
        {
            while (!gameOver && enemy.CurrentHealth > 0)
            {
                await PerformTurn(enemy, player);
                if (gameOver) break; // Check if the game should end before the delay
                await Task.Delay(1000); // Time between turns
            }
        }

        private async Task PerformTurn(IUnit attacker, IUnit defender)
        {
            await turnSemaphore.WaitAsync();
            try
            {
                if (defender.CurrentHealth > 0 && !gameOver)
                {
                    await attacker.AttackAsync(defender);
                    if (defender.CurrentHealth <= 0)
                    {
                        
                        gameOver = true;
                    }
                }
            }
            finally
            {
                turnSemaphore.Release();
            }
        }

        private void InitializeGame()
        {
            Console.WriteLine("\nGame started!\n");
        }

        private void EndGame()
        {
            gameOver = true;
            Console.WriteLine("Game over!");
            if (player.CurrentHealth > 0)
                Console.WriteLine($"{player.Name} wins!");
            else
                Console.WriteLine($"{enemy.Name} wins!");
        }
    }
}
