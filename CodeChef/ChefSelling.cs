using System;

public class Test
{
    public static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');

        int nA = int.Parse(inputs[0]);
        int nB = int.Parse(inputs[1]);
        int nC = int.Parse(inputs[2]);

        int nIngredients = nB + nC;
        int nResult = nA - nIngredients;

        Console.WriteLine(nResult);
    }
}
