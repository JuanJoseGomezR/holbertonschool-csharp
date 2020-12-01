using System;

namespace _2_print_alphabet
{
	class Program
	{
		static void Main(string[] args)
		{
			string coma= "";
			int i;
			int j;
			for (i = 0; i <= 9; i++)
			{ 
				for (j = i + 1; j <= 9; j++)
				{
					Console.Write("{0}{1}{2}",coma, i, j);
					coma = ", ";
				} 
			}
			Console.Write("\n");
		}
	}
}

