using System;

/// <summary>Class Base</summary>
public abstract class Base 
{
    /// <summary>Public property</summary>
    public string name;
    
    /// <summary>Overides to string method</summary>
        public override string ToString()
        {
            return name + " is a " + GetType();
        }
    
}