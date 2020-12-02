using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
	{
		myDict.Remove(myDict[key]);
		return myDict;
	}
}

