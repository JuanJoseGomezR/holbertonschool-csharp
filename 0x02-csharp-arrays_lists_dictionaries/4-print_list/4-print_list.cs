using System;
using System.Linq;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return (null);
		}
		List<int> new_list = Enumerable.Range(0, size).ToList();
		Console.WriteLine(string.Format("{0}", string.Join(" ", new_list)));
		return (new_list);
	}
}

