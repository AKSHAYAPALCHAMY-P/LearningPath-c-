namespace FibonacciSeries
{
	public class FibonacciSeries
	{
		public static void main(string[] args)
		{
			int nValue = 1;
			int nSum = 0;

			if(nValue % 2 == 0)
			{
				if(nSum <= 4000000000)
				{
					nSum += nValue;
				}
			}

			Console.WriteLine(nSum);
		}

	}
}
