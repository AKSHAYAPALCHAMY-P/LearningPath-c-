using System;

namespace ReversedArray
{
	public class ArrayReversing
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the array length:");
			bool nLength = int.TryParse(Console.ReadLine(), out int nSize);

			int[] nInputArray = new int[nSize];
			int[] nOutputArray = new int[nSize];


			for(int i = 0; i < nSize; i++)
			{
				nInputArray[i] = int.Parse(Console.ReadLine());
			}

			for(int i = nInputArray.Length - 1, j = 0; i >= 0; i--,j++)
			{
				nOutputArray[j] = nInputArray[i];
			}

			foreach(int OutPutValue in nOutputArray)
			{
				Console.Write(OutPutValue+" ");
			}
		}
	}
}
