namespace ThatIsMyScore
{
	public class MyScore
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the Number of submissions:");
			bool NSubmissions = int.TryParse(Console.ReadLine(), out int nSubmit);

			int[] nScores = new int[9];

			for(int i = 0; i < nSubmit; i++)
			{
				Console.WriteLine("Enter the ProblemNumber:");
				bool nProblemNumber = int.TryParse(Console.ReadLine(), out int nProblem);

				Console.WriteLine("Enter the Submissionscore:");
				bool bScore = int.TryParse(Console.ReadLine(), out int nSubmissionScore);

				if(nProblem <= 8 && nProblem >= 1)
				{
					if(nSubmissionScore > nScores[nProblem])
					{
						nScores[nProblem] = nSubmissionScore;
					}
				}
			}

			int nTotalScore = 0;
			for(int i = 0; i <= 8; i++)
			{
				nTotalScore = nTotalScore + nScores[i];
			}

			Console.WriteLine(nTotalScore);
		}
	}
}