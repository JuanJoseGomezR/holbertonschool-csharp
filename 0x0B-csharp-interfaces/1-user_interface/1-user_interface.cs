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
/// <summary>Interface</summary>
public interface IInteractive
{
	/// <summary>method</summary>
	void Interact();
}
/// <summary>Interface</summary>
public interface IBreakable
{
	/// <summary>Properties</summary>
	int durability
	{ get; set; }
	/// <summary>method</summary>
	void Break();
}
/// <summary>Interface</summary>
public interface ICollectible
{
	/// <summary>Properties</summary>
	bool isCollected
	{ get; set; }
	/// <summary>method</summary>
	void Collect();
}
/// <summary>Class that that inherits from ...</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectible
{
	/// <summary>Properties</summary>
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

