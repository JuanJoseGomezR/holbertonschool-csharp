using System;
using System.Text.RegularExpressions;

namespace Text
{
     /// <summary>Str Class</summary>
    public class Str
    {
        /// <summary> find the first unique char </summary>
        public static int UniqueChar(string s)
        {
            if(s == "" || s == null)
            {
                return(-1);
            }
            s = s.ToLower();
            char[] arr = s.ToCharArray();
            int x;
            for(int y=0; y <= arr.Length-1; y++)
            {
                x = 0;
                for(int z=0; z <= arr.Length-1; z++)
                {
                    if (y != z)
                        if(arr[y] == arr[z])
                            x += 1;                    
                }
                if (x == 0)
                    return y;
            }
            return -1;
        }
    }
}