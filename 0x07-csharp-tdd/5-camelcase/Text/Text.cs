using System;

namespace Text
{
    /// <summary> new class Str </summary>
    public class Str
    {
        /// <summary> counts the number of words in a string </summary>
        public static int CamelCase(string s)
        {
            int counter = 1;
             if (s == "")
            {
                return 0;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && !Char.IsUpper(s[i + 1]))
                {
                    return counter;
                }
                if (s[i] == ' ' && Char.IsUpper(s[i + 1]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
