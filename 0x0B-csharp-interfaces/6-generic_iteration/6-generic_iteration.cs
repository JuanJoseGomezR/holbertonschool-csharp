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

public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem = false;

    public int durability
    { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability == 0)
        {
            Console.WriteLine("The {0} has been broken", name);
        }
        if (isQuestItem == true)
        {
            Console.WriteLine("You look a the {0}. There's a key inside.", name);
        }
        if (isQuestItem == false)
        {
            Console.WriteLine("You look a the {0}. Not much to see here.", name);
        }
    }

    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine("You hit the {0}. It cracks.", name);
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the {0}. What a mess.", name);
        }
        else
        {
            Console.WriteLine("The {0} is already broken.", name);
        }
    }
}

public class Key : Base, ICollectable
{
    public bool isCollected
    { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
        else
        {
            Console.WriteLine("You have already picked up the {0}.", name);
        }
    }
}

/// <summary>Class generic t</summary>
class Objs<T> : IEnumerable<T> 
{
  
  List<T> objects = new List<T> ();
   
   public void Add(T item)
    {
      objects.Add(item);
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in objects)
        {
            yield return (item);
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}