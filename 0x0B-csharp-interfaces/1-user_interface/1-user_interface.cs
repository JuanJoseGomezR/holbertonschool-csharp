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

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability
    { get; set; }
    /// <summary>Properties</summary>
	public bool isCollected
    { get; set; }
    /// <summary>inherited method</summary>
    public void Interact()
    {

    }
    /// <summary>inherited method</summary>
    public void Break()
    {

    }
    /// <summary>inherited method</summary>
    public void Collect()
    {

    }
}