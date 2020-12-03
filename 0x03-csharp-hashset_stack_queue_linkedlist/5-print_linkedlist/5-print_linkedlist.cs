using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		LinkedList<int> newllist = new LinkedList<int>();

		for (int i = 0; i < size; i++)
		{
			newllist.AddLast(i);
		}
		foreach (int item in newllist)
		{
			Console.WriteLine(item);
		}
		return newllist;
	}
}

