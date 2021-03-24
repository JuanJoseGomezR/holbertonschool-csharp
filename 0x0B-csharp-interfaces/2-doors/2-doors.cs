using System;

///<summary>Abstrac class</summary>
public abstract class Base
{
    public string name;

    public override string ToString()
    {
        return name + " " + "is a " + GetType();
    }
}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability
    { get; set; }

    void Break();
}

public interface ICollectable
{
    bool isCollected
    { get; set; }

    void Collect();
}

public class Door : Base, IInteractive
{
    public Door(string door = "Door")
    {
        name = door;
    }
    /// <summary>inherited method</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked", name);
    }
}