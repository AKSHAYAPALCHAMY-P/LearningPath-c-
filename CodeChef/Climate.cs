using System;

public class Climate
{
    public static void Main()
    {
        string[] nClimate = Console.ReadLine().Split(' ');

        int nRainy = int.Parse(nClimate[0]);
        int nCloudy = int.Parse(nClimate[1]);

        int nTotalDays = 7;

        int nClear = nTotalDays - (nRainy + nCloudy);

        Console.WriteLine(nClear);
    }
}
