using System;

class Obj
{
	public static void Print(object myObj)
	{
		Type t = myObj.GetType();


		Console.WriteLine("{0} Properties:", t.Name);
		foreach (var properties in t.GetProperties())
		{
			Console.WriteLine(properties.Name);
		}
		Console.WriteLine("{0} Methods:", t.Name);
		foreach (var methods in t.GetMethods())
		{
			Console.WriteLine(methods.Name);
		}
	}
}
