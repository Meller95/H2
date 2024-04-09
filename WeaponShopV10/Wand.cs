
/// <summary>
/// This class represents a Wand. A Wand is 
/// considered to be a weapon.
/// </summary>
public class Wand : Weapon
{
    public const int InitialWandMinDamage = 10;
    public const int InitialWandMaxDamage = 30;
    public bool IsEnchanted { get; set; }

    public double DamageFromWand()
    { 
        double damage = CalculateDamage();

        if (IsEnchanted)
        {
            damage *= 2;
        }

        return damage;
    }
    #region Constructor
    public Wand(string description)
        : base(description, InitialWandMinDamage, InitialWandMaxDamage)
    {
    }
    #endregion
}
