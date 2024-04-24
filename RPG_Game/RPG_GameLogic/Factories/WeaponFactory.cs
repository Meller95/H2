using RPG_GameLogic.Interfaces;
using RPG_GameLogic.Items.Weapons;
using System;
using System.Collections.Generic;

namespace RPG_GameLogic.Factories
{
    public static class WeaponFactory
    {
        private static Random rng = new Random();

        public static IWeapon CreateWeapon(string weaponType = null)
        {
            if (string.IsNullOrEmpty(weaponType))
            {
                var weapons = new List<string> { "Sword", "Axe", "Boomerang" };
                int index = rng.Next(weapons.Count);
                weaponType = weapons[index];
            }

            return weaponType switch
            {
                "Sword" => new Sword(),
                "Axe" => new Axe(),
                "Boomerang" => new Boomerang(),
                _ => throw new ArgumentException("Unknown weapon type", nameof(weaponType)),
            };
        }
    }
}
