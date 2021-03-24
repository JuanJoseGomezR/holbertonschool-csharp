using System;

///<summary>Player class</summary>
public class Player
{
	private string name;
	private float maxHP;
	private float hp;

	///<summary>Constructor</summary>
	public Player(string name="Player", float maxHP=100f)
	{
		if (maxHP <= 0)
		{
			this.maxHP = 100f;
			Console.WriteLine("maxHP must be greater than 0. maxHp set to 100f by default");
		}
		this.hp = maxHP;
		this.name = name;
		this.maxHP = maxHP;
	}

	///<summary>Print health of player method</summary>
	public void PrintHealth()
	{
		Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHP);
	}
}
