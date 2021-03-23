using System;

///<summary>Abstrac class</summary>
public abstract class Base
{
    /// <summary>Public property</summary>
    public string name;

    /// <summary>Public property</summary>
    public override string ToString()
    {
        return name + " " + "is a " + GetType();
    }
}
