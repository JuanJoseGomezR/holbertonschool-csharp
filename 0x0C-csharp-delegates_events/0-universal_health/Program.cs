using System;

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
}