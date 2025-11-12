namespace SumOfArray
{
	public class AddingArrayValues
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the Array Length:");
			bool nLength = int.TryParse(Console.ReadLine(), out int nSize);

			int[] nArray = new int[nSize];
			for(int i = 0; i < nSize; i++)
			{
				Console.WriteLine("Enter Array values:");
				
				bool nValue = int.TryParse(Console.ReadLine(), out int nElement);

				nArray[i] = nElement;
			}
			AddingArrayValues addingArrayValues = new AddingArrayValues();
			int nResult = addingArrayValues.SimpleArraySum(nArray);

			Console.WriteLine(nResult);
		}

		public int SimpleArraySum(int[] nArray)
		{
			int sum = 0;
			foreach(int n in nArray)
			{
				sum += n;
			}

			return sum;
		}
	}
}
