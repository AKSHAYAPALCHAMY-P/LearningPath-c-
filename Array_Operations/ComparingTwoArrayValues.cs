namespace CompareArrayValues
{
	public class ComparingArray
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the Array Length:");
			bool nLength = int.TryParse(Console.ReadLine(), out int nSize);

			int[] nA = new int[nSize];
			int[] nB = new int[nSize];

			Console.WriteLine("Enter Array values for first Array:");

			for(int i = 0; i < nSize; i++)
			{
				bool nValue = int.TryParse(Console.ReadLine(), out int nElement1);

				nA[i] = nElement1;
			}

			Console.WriteLine("Enter Array values for second Array:");
			for(int i = 0; i < nSize; i++)
			{
				bool nValue = int.TryParse(Console.ReadLine(), out int nElement2);

				nB[i] = nElement2;
			}

			ComparingArray obj = new ComparingArray();
			int[] nResult = obj.CompareTriplets(nA, nB);

			Console.WriteLine($"Alice:{nResult[0]},Bob:{nResult[1]}");
		}

		public int[] CompareTriplets(int[] nA, int[] nB)
		{
			int nAlice = 0;
			int nBob = 0;

			int[] nResultArray = new int[2];

			for(int i = 0; i < nA.Length; i++)
			{
				if(nA[i] > nB[i])
				{
					nAlice += 1;
				}

				else if(nA[i] < nB[i])
				{
					nBob += 1;
				}
				else if(nA[i] == nB[i])
				{
					return new int[0];
				}
			}

			for(int i = 0; i < 2; i++)
			{
				nResultArray[0] = nAlice;
				nResultArray[1] = nBob;
			}

			return new[] { nAlice, nBob };
		}
	}
}
