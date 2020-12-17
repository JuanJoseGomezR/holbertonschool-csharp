using System.Text;
using System.Net.Sockets;
using System;
using System.Linq;

namespace Text
{
    /// <summary> new class str </summary>
    public class Str
    {
        /// <summary> checks for a palindrome string </summary>
        public static bool IsPalindrome(string s)
        {
            if (s == "")
            {
                return true;
            }
            string lowered = s.ToLower();
            var newstr = new StringBuilder();

            foreach (char c in lowered)
            {
                if (!char.IsPunctuation(c) && c != ' ')
                    newstr.Append(c);
            }
            string reversed = "";
            for (int i = newstr.Length - 1; i >= 0; i--)
            {
                reversed += newstr[i].ToString();
            }
            string lol = newstr.ToString();
            if (reversed == lol)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}