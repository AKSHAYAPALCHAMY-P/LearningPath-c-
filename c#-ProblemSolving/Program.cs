namespace PlayingWithStrings
{
	public class PlayingWithStrings
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the target string;");
			string strTargetString = Console.ReadLine();

			Console.WriteLine("Enter the Binary String:");
			string strBinaryString = Console.ReadLine();

			//char[] strBinaryStringArray = 

			if(strBinaryString != strTargetString)
			{
				Console.WriteLine("No");
			}

			int nOnesCountInTargetString = strTargetString.Count(c => c == '0');
			int nZeroesCountnTargetString = strTargetString.Count(c => c == '1');
			int nOnesCountInBinaryString = strBinaryString.Count(c => c == '0');
			int nZeroesCountInBinaryString = strBinaryString.Count(c => c == '1');

			if(nOnesCountInBinaryString == nOnesCountInTargetString && nZeroesCountInBinaryString == nZeroesCountnTargetString)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				//	for(int i = 0; i < strTargetString.Length; i++)
				//	{
				//		for(int j = 0; j < i; j++)
				//		{
				//		}
				//	}
				Console.WriteLine("No");
			}
		}
	}
}

