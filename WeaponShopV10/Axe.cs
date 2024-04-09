
/// <summary>
/// This class represents a Axe. An Axe is 
/// considered to be a weapon.
/// </summary>
public class Axe : Weapon
{
    public const int InitialAxeMinDamage = 20;
    public const int InitialAxeMaxDamage = 50;

    public double DamageFromAxe()
    {
        double damage = CalculateDamage();
        MinDamage -= 3;
        MaxDamage -= 3;
        return damage;

    }

    public void Sharpen()
    {
        MinDamage = InitialAxeMinDamage;
        MaxDamage = InitialAxeMaxDamage;
    }
    #region Constructor
    public Axe(string description)
        : base(description, InitialAxeMinDamage, InitialAxeMaxDamage)
    {
    }
    #endregion
}