using System;

/// <summary>
/// ienf
/// </summary>
interface IInteractive
{
    void Interact();
}
/// <summary>
/// sef
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}
/// <summary>
/// efe
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// eeg
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    /// <summary>
    /// inters
    /// </summary>
    public void Interact()
    {

    }
    /// <summary>
    /// ed
    /// </summary>
    public void Break()
    {

    }
    /// <summary>
    /// eogr
    /// </summary>
    public void Collect()
    {

    }
}