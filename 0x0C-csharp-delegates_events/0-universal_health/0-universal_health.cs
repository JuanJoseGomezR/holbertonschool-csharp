using System;

///<summary>Player class</summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;

	///<summary>Constructor</summary>
	public Player(string name="Player", float maxHp=100f)
	{
		if (maxHp <= 0)
		{
			this.maxHp = 100f;
			Console.WriteLine("maxHP must be greater than 0. maxHp set to 100f by default");
		}
		this.hp = maxHp;
		this.name = name;
		this.maxHp = maxHp;
	}

	///<summary>Print health of player method</summary>
	public void PrintHealth()
	{
		Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
	}
}
