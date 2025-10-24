using System;
using System.Runtime.InteropServices.JavaScript;

namespace LargestPalindrome
{
	class LargestPalindromeOfThreeDigit
	{
		public static void Main(string[] args)
		{
			int K = 0;
			for(int i = 100; i < 999; i++)
			{
				for(int j = i; j < 999; j++)
				{
					K = i * j;
				}

				Console.WriteLine(K);
			}
		}
	}
}

