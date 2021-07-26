using System;

///<summary>Generic queue class implementation.</summary>
public class Queue<T>
{
    /// <summary>checks type of T</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}