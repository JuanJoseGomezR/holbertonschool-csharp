using System;
using System.Collections.Generic;
using System.Linq;

class List
{
	public static int Sum(List<int> myList)
	{
		int result = 0;
		foreach (int nums in myList.Distinct().ToList())
		{
			result += nums;
		}
		return (result);
	}
}

