using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name property
    /// </summary>
    /// <value>Getter and setter</value>
    public string name;

    /// <summary>
    /// Overrides ToString Method
    /// </summary>
    public override string ToString()
    {
        return ($"{name} is a {this.GetType()}");
    }
}

/// <summary>
/// Interactive interface
/// </summary>
interface IInteractive
{
    /// <summary>
    /// Used for interactions.
    /// </summary>
    void Interact();
}

/// <summary>
/// IBreakable interface
/// </summary>
interface IBreakable
{
    int durability { get; set; }

    /// <summary>
    /// Used to break an item.
    /// </summary>
    void Break();

}

/// <summary>
/// ICollectable interface
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }

    /// <summary>
    /// Used to collect something.
    /// </summary>
    void Collect();
}

/// <summary>
/// Door class
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Door default constructor
    /// </summary>
    /// <param name="Name">Default name Door, value constructor</param>
    public Door(string Name="Door")
    {
        this.name = Name;
    }

    /// <summary>
    /// Used for interactions.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
/// <summary>
/// Decoration class
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    /// <summary>
    /// Decoration constructor
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="durability">how much it can last</param>
    /// <param name="isQuestItem">is a quest item</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            Console.WriteLine("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    /// <summary>
    /// Interact method
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Break method
    /// </summary>
    public void Break()
    {
        durability -= 1;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }

        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }

        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// Key class
/// </summary>
public class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    /// <summary>
    /// Key constructor
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="isCollected">collected</param>
    public Key(string name="Key", bool isCollected=false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collecting object
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

/// <summary>
/// Objects
/// </summary>
class RoomObjects
{
    /// <summary>
    /// Iterate through objects
    /// </summary>
    /// <param name="roomObjects">all the objects</param>
    /// <param name="type">type of object</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        
        foreach (Base objct in roomObjects)
        {
            if (type == typeof(IInteractive) && objct is IInteractive)
                ((IInteractive)objct).Interact();
            if (type == typeof(IBreakable) && objct is IBreakable)
                ((IBreakable)objct).Break();
            if (type == typeof(ICollectable) && objct is ICollectable)
                ((ICollectable)objct).Collect();
        }
    }
}