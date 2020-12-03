using System;
using System.Collections.Generic;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		if (myLList.Count < 1)
		{
			return 0;
		}
		int deleted = myLList.First.Value;
		myLList.RemoveFirst();
		return deleted;
	}
}

