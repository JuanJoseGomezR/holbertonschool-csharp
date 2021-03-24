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

	///<summary> Delegate to calculate health </summary>
	public delegate float CalculateHealth(float health);

	///<summary> Damage taken </summary>
	public void TakeDamage(float damage)
	{
		if(damage < 0)
		{
			damage = 0;
			Console.WriteLine("{0} takes 0 damage!", name);
		}
		else
		{
			Console.WriteLine("{0} takes {1} damage!", name, damage);
		}
	}

	///<summary> Healing </summary>
	public void HealDamage(float heal)
	{
		if (heal == 0)
		{
			Console.WriteLine("{0} heals = HP!", name);
		}
		else
			Console.WriteLine("{0} heals {1} HP!", name, heal);
	}
}
