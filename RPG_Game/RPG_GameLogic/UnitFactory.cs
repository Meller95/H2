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
                    
                    return new Player("Hero", "The brave protagonist of our story", 150, weapon);
                case "Enemy":
                    
                    int health = new Random().Next(40, 60);
                    return new Enemy("Goblin", "A sneaky goblin", health, weapon);
                default:
                    throw new ArgumentException("Invalid unit type", nameof(unitType));
            }
        }
    }
}
