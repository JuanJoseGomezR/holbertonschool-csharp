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