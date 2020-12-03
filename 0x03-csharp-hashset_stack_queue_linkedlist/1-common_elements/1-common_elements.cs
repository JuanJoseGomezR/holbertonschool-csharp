using System;
using System.Collections.Generic;

class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
	{
		List<int> newlist = new List<int>();

		foreach (int num in list1)
		{
			if (list2.Contains(num))
			{
				newlist.Add(num);
			}
		}
		return newlist;
	}
}

