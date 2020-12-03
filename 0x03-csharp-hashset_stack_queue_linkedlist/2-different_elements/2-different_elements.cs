using System;
using System.Collections.Generic;

class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> newlist = new List<int>();

		foreach (int num in list1)
		{
			if (list2.Contains(num))
			{
				continue;
			}
			newlist.Add(num);
		}
		foreach (int num2 in list2)
		{
			if (list1.Contains(num2))
			{
				continue;
			}
			newlist.Add(num2);
		}
		newlist.Sort();
		return newlist;
	}
}

