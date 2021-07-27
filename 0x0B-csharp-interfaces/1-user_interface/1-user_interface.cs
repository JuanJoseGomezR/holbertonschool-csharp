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
    public string name { get; set; }

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
/// Testobjecy
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    /// <summary>
    /// interact
    /// </summary>
    public void Interact()
    {

    }

    /// <summary>
    /// break
    /// </summary>
    public void Break()
    {

    }

    /// <summary>
    /// collect
    /// </summary>
    public void Collect()
    {

    }
}