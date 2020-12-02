using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		string name = "";
		if (myList.Count < 1)
		{
			return "None";
		}
		foreach (KeyValuePair<string, int> reco in myList)
		{
			int bigg = myList.Values.Max();
			if (reco.Value == bigg)
			{
				name = reco.Key;
			}
		}
		return name;
	}
}

