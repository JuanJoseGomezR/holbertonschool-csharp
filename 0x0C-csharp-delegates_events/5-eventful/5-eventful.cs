using System;

///<summary>Calculates modifiers</summary>
public enum Modifier
{
	Weak = 1,
	Base = 2,
	Strong = 3
}

///<summary> current hp arguments </summary>
class CurrentHPArgs : EventArgs
{
	public readonly float currentHp;

	public CurrentHPArgs(float newHp)
	{
		currentHp = newHp;
	}

}

///<summary>select modifer</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Player class</summary>
public class Player
{
	///<summary> event handler hpcheck</summary>
	EventHandler<CurrentHPArgs> HPCheck;

	private string name;
	private float maxHp;
	private float hp;
	private string status;

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
		this.status = $"{this.name} is ready to go!";
		HPCheck += CheckStatus;
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
		OnCheckStatus(new CurrentHPArgs(this.hp));
	}

	///<summary>modifier returns</summary>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		return (baseValue * ((float)modifier / 2));
	}

	///<summary>eventhandler hpcheck</summary>
	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == this.maxHp)
			this.status = $"{this.name} is in perfect health!";
		else if (e.currentHp >= (this.maxHp / 2))
			this.status = $"{this.name} is doing well!";
		else if (e.currentHp >= (this.maxHp / 4))
			this.status = $"{this.name} isn't doing too great...";
		else if (e.currentHp > 0)
			this.status = $"{this.name} needs help!";
		else
			this.status = $"{this.name} is knocked out!";
		Console.WriteLine(this.status);
	}

	///<summary> hp warnings </summary>
	private void HPValueWarning(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == 0)
		{
			Console.WriteLine("Health has reached zero!");
		}
		else
			Console.WriteLine("Health is low!");
	}

	///<summary> check actual HP </summary>
	void OnCheckStatus(CurrentHPArgs e)
	{
		if (e.currentHp < (maxHp / 4))
		{
			HPCheck += HPValueWarning;
		}
		HPCheck(this, e);
	}
}
