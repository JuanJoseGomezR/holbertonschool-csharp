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
		float newHP = hp - damage;
		ValidateHP(newHP);
	}

	///<summary> Healing </summary>
	public void HealDamage(float heal)
	{
		if (heal < 0)
		{
			heal = 0;
			Console.WriteLine("{0} heals = HP!", name);
		}
		else
			Console.WriteLine("{0} heals {1} HP!", name, heal);
		float newHP = hp + heal;
		ValidateHP(newHP);
	}

	///<summary> validate new hp </summary>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
		{
			hp = 0;
		}
		if (newHp > maxHp)
		{
			hp = maxHp;
		}
		else
		{
			hp = newHp;
		}
	}
}
