namespace HappyNewYear
{
	public class NewYear
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the time now");
			DateTime dtInputTime = DateTime.Parse(Console.ReadLine());

			DateTime nTotalHours = dtInputTime.Date.AddDays(1);

			TimeSpan nRemainingHours = nTotalHours - dtInputTime;

			Console.WriteLine(nRemainingHours);
		}
	}
}