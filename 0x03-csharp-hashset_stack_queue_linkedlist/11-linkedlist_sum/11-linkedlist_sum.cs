using System;
using System.Collections.Generic;

class LList
{
	public static int Sum(LinkedList<int> myLList)
	{
		int summ = 0;
		foreach (int item in myLList)
		{
			summ += item;
		}
		return summ;
	}
}

