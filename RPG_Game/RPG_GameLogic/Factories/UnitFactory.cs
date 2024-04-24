using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Units;

namespace RPG_GameLogic.Factories
{
    public static class UnitFactory
    {
        public static IUnit CreateUnit(string unitType, IWeapon weapon)
        {
            switch (unitType)
            {
                case "Player":
                    // Assume Player has similar constructor requirements
                    return new Player("Hero", "The brave protagonist of our story", 150, weapon);
                case "Enemy":
                    // Providing a description and random health here
                    int health = new Random().Next(75, 96);  // Random health between 75 and 95
                    return new Enemy("Goblin", "A sneaky goblin", health, weapon);
                default:
                    throw new ArgumentException("Invalid unit type", nameof(unitType));
            }
        }
    }
}
