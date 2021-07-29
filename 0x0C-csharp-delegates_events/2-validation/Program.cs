using System;


/// <summary>
/// Delegate
/// </summary>
/// <param name="health">amount of health</param>
public delegate void CalculateHealth(float health);
/// <summary>
/// Player class
/// </summary>
public class Player
{
    public string name { get; set; }
    public float maxHp { get; set; }
    public float hp { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">name of player</param>
    /// <param name="maxHp">max hp of player</param>
    public Player(string name="Player", float maxHp=100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Print Health points
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    
    /// <summary>
    /// Damage Taken by player
    /// </summary>
    /// <param name="damage">amount of damage</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        this.ValidateHP(this.hp - damage);
    }

    /// <summary>
    /// Player heals
    /// </summary>
    /// <param name="heal">amount healed</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        this.ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// Validate health points
    /// </summary>
    /// <param name="newHp">new hp</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0){
            this.hp = 0;
        } else if (newHp >= maxHp){
            this.hp = maxHp;
        } else{
            this.hp = newHp;
        }
    }
}