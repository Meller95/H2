using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Units;
using System;

namespace RPG_GameLogic.Factories
{
    public class UnitFactory
    {
        public static IUnit CreateUnit(string unitType, IWeapon weapon)
        {
            switch (unitType)
            {
                case "Player":
                    return new Player(weapon);
                case "Enemy":
                    return new Enemy(weapon);
                default:
                    throw new ArgumentException("Invalid unit type", nameof(unitType));
            }
        }
    }
}
