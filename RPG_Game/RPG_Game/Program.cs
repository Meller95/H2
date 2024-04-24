using RPG_GameLogic.Factories;
using RPG_GameLogic.GameManagement;
using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Units;

class Program
{
    static async Task Main(string[] args)
    {
        IWeapon playerWeapon = ChooseWeapon();
        // Provide the full set of required parameters to create a Player
        Player player = new Player("Hero", "The brave protagonist of our story", 150, playerWeapon);

        Game game = new Game(player);  // Only pass the player
        await game.StartGameAsync();
    }

    private static IWeapon ChooseWeapon()
    {
        Console.WriteLine("Choose your weapon:");
        Console.WriteLine("1: Sword");
        Console.WriteLine("2: Axe");
        Console.WriteLine("3: Boomerang");

        while (true)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    return WeaponFactory.CreateWeapon("Sword");
                case "2":
                    return WeaponFactory.CreateWeapon("Axe");
                case "3":
                    return WeaponFactory.CreateWeapon("Boomerang");
                default:
                    Console.WriteLine("Invalid choice, please choose 1 for Sword or 2 for Axe.");
                    break;
            }
        }
    }
}
