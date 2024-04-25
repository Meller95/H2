using RPG_GameLogic.Factories;
using RPG_GameLogic.GameManagement;
using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Units;

class Program
{
    static async Task Main(string[] args)
    {
        IWeapon playerWeapon = ChooseWeapon();

        Player player = new Player("Hero", "The brave protagonist of our story", 150, playerWeapon);

        Game game = new Game(player);

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
                    Console.WriteLine("Invalid choice, please choose 1 for Sword, 2 for Axe or 3 for boomerang.");
                    break;
            }
        }
    }
}
