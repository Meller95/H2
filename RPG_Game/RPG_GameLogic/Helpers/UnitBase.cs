using RPG_GameLogic.Interfaces;
using System.Threading.Tasks;

public abstract class UnitBase : IUnit
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int MaxHealth { get; protected set; }
    public int CurrentHealth { get; set; }
    public IWeapon Weapon { get; protected set; }

    protected UnitBase(string name, string description, int maxHealth, IWeapon weapon)
    {
        Name = name;
        Description = description;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        Weapon = weapon ?? throw new ArgumentNullException(nameof(weapon), "Weapon cannot be null.");
    }

    public virtual async Task AttackAsync(IUnit target)
    {
        await Weapon.AttackAsync(this, target);
    }

    public virtual void Die()
    {
        Console.WriteLine($"{Name} has been defeated.\n");
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} moves.");
    }

    public virtual void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0) Die();
    }
}
