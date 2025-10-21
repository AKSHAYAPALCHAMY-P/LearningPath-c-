using System;

public class Triangles
{
    public static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');

        int A = int.Parse(inputs[0]);
        int B = int.Parse(inputs[1]);

        int C = 180 - (A + B);

        Console.WriteLine(C);
    }
}
